package com.example.rest.dao;
import java.sql.Connection;
import java.sql.PreparedStatement;
import java.sql.ResultSet;
import java.sql.SQLException;
import java.util.ArrayList;
import java.util.List;

import org.apache.commons.logging.Log;
import org.apache.commons.logging.LogFactory;

import com.example.rest.util.ConectaDB;

import om.example.rest.entidades.ListaUbigeo;

public class ListaUbigeoDao {

private static final Log log = LogFactory.getLog(ListaUbigeoDao.class);
	
	
	public List<ListaUbigeo> listarUbigeo(String depa,String prov,String dis) {
		Connection conn = null;
		PreparedStatement pstm = null;
		ResultSet rs = null;
		
		List<ListaUbigeo> lista = new ArrayList<ListaUbigeo>();
		try {
			String sql = "call sp_list_ubigeo (?,?,?)";
			conn = new ConectaDB().getAcceso();
			pstm = conn.prepareStatement(sql);
			pstm.setString(1, depa);
			pstm.setString(2, prov);
			pstm.setString(3, dis);
			log.info(pstm);
			rs = pstm.executeQuery();
			ListaUbigeo bean = null;
			while(rs.next()){
				bean = new ListaUbigeo();
				bean.setDepa(rs.getString(1));
				bean.setProv(rs.getString(2));
				bean.setDistri(rs.getString(3));
				lista.add(bean);
			}
		} catch (Exception e) {
			log.info(e);
		} finally {
			try {
				if (rs != null)rs.close();
				if (pstm != null)pstm.close();
				if (conn != null)conn.close();
			} catch (SQLException e) {}
		}
		return lista;
	}

}
