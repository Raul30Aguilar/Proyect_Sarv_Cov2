package com.example.rest.util;


import java.sql.Connection;
import java.sql.DriverManager;

/**
 *
 * @author Instructor
 */
public class ConectaDB {

        public Connection getAcceso() throws Exception {
        	Class.forName("com.mysql.cj.jdbc.Driver");
//        	Connection conn = DriverManager.getConnection("jdbc:mysql://node225382-env-0373391.j.layershift.co.uk/rest?serverTimezone=UTC","root","VYOxrh76162");
        	Connection conn = DriverManager.getConnection("jdbc:mysql://localhost:3306/sars_cov_2?serverTimezone=UTC","root","mysql");
           	
        return conn;
    }
        
        
}
