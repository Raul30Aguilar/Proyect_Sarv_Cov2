package om.example.rest.entidades;

import java.io.Serializable;

public class AddStatusCiu implements Serializable {
	/**
	 * 
	 */
	private static final long serialVersionUID = 1L;
	
	private int idstatus;
	private int doc;
	private int triaje;
	private String fechaRegistro;
	private String fechaModificacion;
	
	
	public int getIdstatus() {
		return idstatus;
	}
	public void setIdstatus(int idstatus) {
		this.idstatus = idstatus;
	}
	public int getDoc() {
		return doc;
	}
	public void setDoc(int doc) {
		this.doc = doc;
	}
	public int getTriaje() {
		return triaje;
	}
	public void setTriaje(int triaje) {
		this.triaje = triaje;
	}
	public String getFechaRegistro() {
		return fechaRegistro;
	}
	public void setFechaRegistro(String fechaRegistro) {
		this.fechaRegistro = fechaRegistro;
	}
	public String getFechaModificacion() {
		return fechaModificacion;
	}
	public void setFechaModificacion(String fechaModificacion) {
		this.fechaModificacion = fechaModificacion;
	}

}
