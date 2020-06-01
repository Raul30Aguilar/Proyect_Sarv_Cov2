package om.example.rest.entidades;

import java.io.Serializable;

public class ModiStatusCiud implements Serializable{

	/**
	 * 
	 */
	private static final long serialVersionUID = 1L;
	private int idstatus;
	private int doc;
	
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
	
}
