package music.jgo.dev.daoImpl;

import java.sql.Connection;
import java.sql.Driver;
import java.sql.PreparedStatement;
import java.sql.ResultSet;
import java.sql.SQLException;
import java.sql.Types;
import java.util.ArrayList;
import java.util.Collection;
import java.util.HashMap;
import java.util.Iterator;
import java.util.LinkedList;
import java.util.List;
import java.util.Map;

import org.springframework.core.Constants;
import org.springframework.jdbc.core.JdbcTemplate;
import org.springframework.jdbc.core.SqlOutParameter;
import org.springframework.jdbc.datasource.SimpleDriverDataSource;

import music.jgo.dev.dao.SongDao;
import music.jgo.dev.models.Song;
import music.jgo.dev.utils.ConnectionProvider;

import org.springframework.jdbc.core.namedparam.MapSqlParameterSource;
import org.springframework.jdbc.core.namedparam.SqlParameterSource;
import org.springframework.jdbc.core.simple.SimpleJdbcCall;


public class SongDaoImpl implements SongDao {
	
	ConnectionProvider con =  new ConnectionProvider();
	



	@Override
	public List<Song> getAll() {
		System.out.println("listing Songs");
		List<Song> Songs =  new ArrayList<Song>();
		
		SimpleJdbcCall simpleJdbcCall = new SimpleJdbcCall(con.jdbcTemplate)
				.withProcedureName("spListSongs");
		System.out.println("procedure");
		Map<String, Object> simpleJdbcCallResult = simpleJdbcCall.execute();
		
		

		ArrayList SongsResult =  new ArrayList();
		SongsResult =(ArrayList) (simpleJdbcCallResult).get("#result-set-1");

		for(int a=0; a<SongsResult.size();a++){

			Song Song1 = new Song();
			Song1.setSongId((int) ((Map<String, Object>) SongsResult.get(a)).get("songId"));
			Song1.setSongName((String) ((Map<String, Object>) SongsResult.get(a)).get("songName"));
			Song1.setSongAutor((String) ((Map<String, Object>) SongsResult.get(a)).get("songAutor"));
			Song1.setSongYear((String)((Map<String, Object>) SongsResult.get(a)).get("songYear"));

			Songs.add(Song1);

		}
		

		return Songs;
		
	}
	
	
}

