package au.flowmatters.fews.plugins.source;

import java.awt.FlowLayout;
import java.awt.event.ActionEvent;
import java.awt.event.ActionListener;
import java.io.IOException;
import java.util.ArrayList;

import javax.swing.JButton;
import javax.swing.JPanel;

import nl.wldelft.fews.gui.explorer.FewsEnvironment;
import nl.wldelft.fews.gui.explorer.FewsExplorerPlugin;
import nl.wldelft.fews.system.data.DataStore;
import nl.wldelft.fews.system.data.DataStoreException;
import nl.wldelft.fews.system.data.config.Config;
import nl.wldelft.fews.system.data.config.files.ConfigFile;
import nl.wldelft.fews.system.data.config.region.PiClientDescriptor;
import org.apache.log4j.Logger;

public class SourceServiceController extends JPanel implements
		FewsExplorerPlugin {
	private static final long serialVersionUID = -8617095560285855001L;
	private static final Logger log = Logger
			.getLogger(SourceServiceController.class);
	private static ArrayList<SourceServer> serversPendingShutdown = new ArrayList<SourceServer>();

	private FewsEnvironment environment;
	private ArrayList<SourceServer> servers = new ArrayList<SourceServer>();
	private long lastLogTime = 0;
	private boolean shutDown = false;
	private JButton start;
	private JButton stop;
	private JButton restart;

	public SourceServiceController() {
		configureUserInterface();
	}
	
	private void configureUserInterface() {
		this.setLayout(new FlowLayout());
		start = new JButton("Start");
		start.addActionListener(new ActionListener() {
			
			@Override
			public void actionPerformed(ActionEvent arg0) {
				log.info("***Start servers***");
				startServers();
			}
		});
		this.add(start);
		
		stop = new JButton("Stop");
		stop.setEnabled(false);
		stop.addActionListener(new ActionListener() {
			
			@Override
			public void actionPerformed(ActionEvent e) {
				log.info("***Stop servers***");	
				stopServers();
			}
		});
		this.add(stop);
		
		restart = new JButton("Restart");
		restart.addActionListener(new ActionListener() {
			
			@Override
			public void actionPerformed(ActionEvent e) {
				log.info("***Restart servers***");
				restartServers();
			}
		});
		this.add(restart);
	}

	@Override
	public void dispose() {
		stopAllServers();
		shutDown = true;
	}

	private void stopAllServers() {
		log.info("Stopping all Source servers");

		for (SourceServer s : servers) {
			log.info("Stopping a server for " + s.getProjectFile()
					+ " on port " + Integer.toString(s.getPortNumber()));
			s.stop();
			serversPendingShutdown.add(s);
		}

		log.info("All Servers stopped");
	}

	@Override
	public boolean isAlive() {
		updateLogs();

		return !shutDown;
	}

	private void updateLogs() {
		long now = System.nanoTime();
		if ((now - lastLogTime) > 1e7) {
			for (SourceServer s : servers) {
				if (s.getStarted())
					s.logAllMessages();
			}
			lastLogTime = System.nanoTime();
		}
	}

	@Override
	public void run(FewsEnvironment env, String arguments) throws Exception {
		log.info("Starting up Source Service Controller");
		try {
			if (!SourceServer.checkRequiredProperties())
				return;

			waitForAnyPendingShutdowns();

			this.environment = env;
			String[] configurationLines = loadConfiguration(arguments);
			int portOffset = findPortOffset();
			
			for (String line : configurationLines) {
				String[] components = line.split(",");
				String projectFile = components[0];
				int portNumber = Integer.parseInt(components[1].replaceAll(
						"(\\r|\\n)", ""));

				SourceServer server = new SourceServer(projectFile, portOffset + portNumber);
				servers.add(server);
			}

			//startServers();
		} catch (Error e) {
			log.error(e.getMessage());
			throw e;
		}
	}

	private void startServers() {
		start.setEnabled(false);
		SourceServerStarter sss = new SourceServerStarter(servers);
		sss.start();
		stop.setEnabled(true);
	}

	private void stopServers() {
		stop.setEnabled(false);
		stopAllServers();
		waitForAnyPendingShutdowns();
		start.setEnabled(true);		
	}
	
	private void restartServers() {
		stopServers();
		startServers();
	}
	
	private int findPortOffset() {
		String username = System.getProperty("user.name").toLowerCase();
		try
		{
			String[] configurationLines = loadConfiguration("UserSourceServerPorts.csv",false);
			
			for( String line : configurationLines) {
				String[] components = line.split(",");
				
				if(components[0].toLowerCase().equals(username))
				{
					log.info("Found Base Port address for " + username);
					return Integer.parseInt(components[1]);
				}
			}
		} catch(IOException e) {
			return 0;
		} catch(DataStoreException e) {
			return 0;
		}
		return 0;
	}

	private void waitForAnyPendingShutdowns() {
		for (SourceServer s : serversPendingShutdown)
			s.stop(true);
		serversPendingShutdown.clear();
	}

	private String[] loadConfiguration(String filename) throws DataStoreException, IOException {
		return loadConfiguration(filename,true);
	}
	
	private String[] loadConfiguration(String filename, boolean errorOnMissing)
			throws DataStoreException, IOException {
		DataStore dataStore = environment.getDataStore();
		Config config = dataStore.getConfig();

		PiClientDescriptor descriptor = new PiClientDescriptor(filename);
		ConfigFile cf = config.getPiClientConfigFiles().getActive(descriptor);
		
		if(cf==null) {
			if(errorOnMissing)
				log.error("No configuration found for Source Server Controller in "
						+ filename);
			return new String[0];
		}

		String configText = cf.getText();

		if (errorOnMissing && configText.isEmpty())
			log.error("No configuration found for Source Server Controller in "
					+ filename);

			return configText.split("\n");
	}

	@Override
	public void toFront() {
		// TODO Auto-generated method stub

	}

}
