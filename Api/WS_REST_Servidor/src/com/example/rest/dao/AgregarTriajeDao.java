package com.example.rest.dao;

import java.sql.Connection;
import java.sql.PreparedStatement;
import java.sql.SQLException;

import org.apache.commons.logging.Log;
import org.apache.commons.logging.LogFactory;

import com.example.rest.util.ConectaDB;

import om.example.rest.entidades.AgregarTriaje;

public class AgregarTriajeDao {
	

	
	private static final Log log = LogFactory.getLog(AgregarTriajeDao.class);
	
	public int registrarTriaje(AgregarTriaje obj) {
		Connection conn = null;
		PreparedStatement pstm = null;
		int salida = -1;
		try {
			String sql = "call sp_add_cuixtriaje (?,?,?,?,?,?,?,?,?,?,?,?,?,?,?,?,?,?,?,?,?,?,?,?,?)";
			conn = new ConectaDB().getAcceso();
			pstm = conn.prepareStatement(sql);
			pstm.setString(1, obj.getNom());
			pstm.setString(2, obj.getApe());
			pstm.setInt(3, obj.getCel());
			pstm.setInt(4, obj.getEdad());
			pstm.setInt(5, obj.getDoc());
			pstm.setString(6, obj.getDir());
			pstm.setInt(7, obj.getDepa());
			pstm.setInt(8, obj.getProv());
			pstm.setInt(9, obj.getDis());
			pstm.setInt(10, obj.getTdoc());
			pstm.setInt(11, obj.getQua1());
			pstm.setInt(12, obj.getQua2());
			pstm.setInt(13, obj.getQua3());
			pstm.setInt(14, obj.getQua4());
			pstm.setInt(15, obj.getQua5());
			pstm.setInt(16, obj.getQua_obe());
			pstm.setInt(17, obj.getQua_enfe());
			pstm.setInt(18, obj.getQua_dia());
			pstm.setInt(19, obj.getQua_hipe());
			pstm.setInt(20, obj.getQua_can());
			pstm.setInt(21, obj.getQua_adu());
			pstm.setInt(22, obj.getQua_ni());
			pstm.setInt(23, obj.getQua_ges());
			pstm.setInt(24, obj.getQua_cro());
			pstm.setInt(25, obj.getPer());

			log.info(pstm);
			salida = pstm.executeUpdate();
		} catch (Exception e) {
			log.info(e);
		} finally {
			try {
				if (pstm != null)pstm.close();
			} catch (SQLException e1) {}
			try {
				if (conn != null)conn.close();
			} catch (SQLException e) {}
		}
		return salida;
	}




}
