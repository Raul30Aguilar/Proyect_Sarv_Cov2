package com.pe.covid.entity.model;

import java.io.Serializable;

import javax.persistence.Entity;
import javax.persistence.GeneratedValue;
import javax.persistence.GenerationType;
import javax.persistence.Id;
import javax.persistence.Table;

@Entity
@Table(name = "ciudadano")
public class Ciudadano implements Serializable {
	/**
	 * 
	 */
	private static final long serialVersionUID = 1L;

	@Id
	@GeneratedValue(strategy = GenerationType.IDENTITY)
	private int idciudadano;
	private String nomciudadano;
	private String apeciudadano;
	private int celciudadano;
	private int edadciudadano;
	private int docciudadano;
	private String dirciudadano;
	private int iddepartamento;
	private int idprov;
	private int iddistrito;
	private int idtipodocumento;
	private String fecha;
	
	
	public int getIdciudadano() {
		return idciudadano;
	}
	public void setIdciudadano(int idciudadano) {
		this.idciudadano = idciudadano;
	}
	public String getNomciudadano() {
		return nomciudadano;
	}
	public void setNomciudadano(String nomciudadano) {
		this.nomciudadano = nomciudadano;
	}
	public String getApeciudadano() {
		return apeciudadano;
	}
	public void setApeciudadano(String apeciudadano) {
		this.apeciudadano = apeciudadano;
	}
	public int getCelciudadano() {
		return celciudadano;
	}
	public void setCelciudadano(int celciudadano) {
		this.celciudadano = celciudadano;
	}
	public int getEdadciudadano() {
		return edadciudadano;
	}
	public void setEdadciudadano(int edadciudadano) {
		this.edadciudadano = edadciudadano;
	}
	public int getDocciudadano() {
		return docciudadano;
	}
	public void setDocciudadano(int docciudadano) {
		this.docciudadano = docciudadano;
	}
	public String getDirciudadano() {
		return dirciudadano;
	}
	public void setDirciudadano(String dirciudadano) {
		this.dirciudadano = dirciudadano;
	}
	public int getIddepartamento() {
		return iddepartamento;
	}
	public void setIddepartamento(int iddepartamento) {
		this.iddepartamento = iddepartamento;
	}
	public int getIdprov() {
		return idprov;
	}
	public void setIdprov(int idprov) {
		this.idprov = idprov;
	}
	public int getIddistrito() {
		return iddistrito;
	}
	public void setIddistrito(int iddistrito) {
		this.iddistrito = iddistrito;
	}
	public int getIdtipodocumento() {
		return idtipodocumento;
	}
	public void setIdtipodocumento(int idtipodocumento) {
		this.idtipodocumento = idtipodocumento;
	}
	public String getFecha() {
		return fecha;
	}
	public void setFecha(String fecha) {
		this.fecha = fecha;
	}
	public Ciudadano(String nomciudadano, String apeciudadano, int celciudadano, int edadciudadano, int docciudadano,
			String dirciudadano, int iddepartamento, int idprov, int iddistrito, int idtipodocumento, String fecha) {
		super();
		this.nomciudadano = nomciudadano;
		this.apeciudadano = apeciudadano;
		this.celciudadano = celciudadano;
		this.edadciudadano = edadciudadano;
		this.docciudadano = docciudadano;
		this.dirciudadano = dirciudadano;
		this.iddepartamento = iddepartamento;
		this.idprov = idprov;
		this.iddistrito = iddistrito;
		this.idtipodocumento = idtipodocumento;
		this.fecha = fecha;
	}
	public Ciudadano() {
	}
	
	
}
