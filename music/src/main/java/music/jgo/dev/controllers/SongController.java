package music.jgo.dev.controllers;

import java.util.ArrayList;
import java.util.List;
import java.util.concurrent.atomic.AtomicLong;
import org.springframework.web.bind.annotation.RequestMapping;
import org.springframework.web.bind.annotation.RequestMethod;
import org.springframework.web.bind.annotation.RequestParam;
import org.springframework.web.bind.annotation.RestController;

import music.jgo.dev.daoImpl.SongDaoImpl;
import music.jgo.dev.models.Song;

@RestController
public class SongController {
	
	SongDaoImpl songDaoImp = new SongDaoImpl();

    @RequestMapping(value = "/songs", method = RequestMethod.GET)
    public List<Song> getAllSongs(){
    	List<Song> Songs =  new ArrayList<Song>();
    	Songs=songDaoImp.getAll();
    	
    	return Songs;
    	

    }
}
