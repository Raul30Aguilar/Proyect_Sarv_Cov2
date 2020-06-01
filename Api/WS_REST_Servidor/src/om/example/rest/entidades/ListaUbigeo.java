package om.example.rest.entidades;

import java.io.Serializable;

public class ListaUbigeo  implements Serializable{

	/**
	 * 
	 */
	
	private static final long serialVersionUID = 1L;
	
	private String depa;
	private String prov;
	private String distri;
	
	public String getDepa() {
		return depa;
	}
	public void setDepa(String depa) {
		this.depa = depa;
	}
	public String getProv() {
		return prov;
	}
	public void setProv(String prov) {
		this.prov = prov;
	}
	public String getDistri() {
		return distri;
	}
	public void setDistri(String distri) {
		this.distri = distri;
	}
	
	
}
