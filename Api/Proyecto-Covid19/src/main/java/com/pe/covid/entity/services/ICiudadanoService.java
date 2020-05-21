package com.pe.covid.entity.services;

import java.util.List;

import com.pe.covid.entity.model.Ciudadano;

public interface ICiudadanoService {
	public Ciudadano get(int idciudadano);
	public List<Ciudadano> getAll();
	public void post(Ciudadano ciudadano);
	public void put(Ciudadano ciudadano, int idciudadano);
	public void delete(int idciudadano);
}
