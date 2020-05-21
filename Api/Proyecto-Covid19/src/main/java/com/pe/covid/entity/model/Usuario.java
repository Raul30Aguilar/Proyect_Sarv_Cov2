package com.pe.covid.entity.model;

import java.io.Serializable;

import javax.persistence.Entity;
import javax.persistence.GeneratedValue;
import javax.persistence.GenerationType;
import javax.persistence.Id;
import javax.persistence.Table;

@Entity
@Table(name = "usuario")
public class Usuario implements Serializable {

	/**
	 * 
	 */
	private static final long serialVersionUID = 1L;
	
	@Id
	@GeneratedValue(strategy=GenerationType.IDENTITY)
	private int idusuario;
	private String nomusuario;
	private String apeusuario;
	private String celusuario;
	private int edadusuario;
	private String docusuario;
	private String dirusuario;
	private int idtriaje;
	private int iddistrito;
	private int iddepartamento;
	private int idtipodocumento;
	private int idprov;
	
	public int getIdusuario() {
		return idusuario;
	}
	public void setIdusuario(int idusuario) {
		this.idusuario = idusuario;
	}
	public String getNomusuario() {
		return nomusuario;
	}
	public void setNomusuario(String nomusuario) {
		this.nomusuario = nomusuario;
	}
	public String getApeusuario() {
		return apeusuario;
	}
	public void setApeusuario(String apeusuario) {
		this.apeusuario = apeusuario;
	}
	public String getCelusuario() {
		return celusuario;
	}
	public void setCelusuario(String celusuario) {
		this.celusuario = celusuario;
	}
	public int getEdadusuario() {
		return edadusuario;
	}
	public void setEdadusuario(int edadusuario) {
		this.edadusuario = edadusuario;
	}
	public String getDocusuario() {
		return docusuario;
	}
	public void setDocusuario(String docusuario) {
		this.docusuario = docusuario;
	}
	public String getDirusuario() {
		return dirusuario;
	}
	public void setDirusuario(String dirusuario) {
		this.dirusuario = dirusuario;
	}
	public int getIdtriaje() {
		return idtriaje;
	}
	public void setIdtriaje(int idtriaje) {
		this.idtriaje = idtriaje;
	}
	public int getIddistrito() {
		return iddistrito;
	}
	public void setIddistrito(int iddistrito) {
		this.iddistrito = iddistrito;
	}
	public int getIddepartamento() {
		return iddepartamento;
	}
	public void setIddepartamento(int iddepartamento) {
		this.iddepartamento = iddepartamento;
	}
	public int getIdtipodocumento() {
		return idtipodocumento;
	}
	public void setIdtipodocumento(int idtipodocumento) {
		this.idtipodocumento = idtipodocumento;
	}
	public int getIdprov() {
		return idprov;
	}
	public void setIdprov(int idprov) {
		this.idprov = idprov;
	}


	public Usuario(String nomusuario, String apeusuario, String celusuario, int edadusuario, String docusuario,
			String dirusuario, int idtriaje, int iddistrito, int iddepartamento, int idtipodocumento, int idprov) {
		super();
		this.nomusuario = nomusuario;
		this.apeusuario = apeusuario;
		this.celusuario = celusuario;
		this.edadusuario = edadusuario;
		this.docusuario = docusuario;
		this.dirusuario = dirusuario;
		this.idtriaje = idtriaje;
		this.iddistrito = iddistrito;
		this.iddepartamento = iddepartamento;
		this.idtipodocumento = idtipodocumento;
		this.idprov = idprov;
	}
	public Usuario() {

	}
	
	
}