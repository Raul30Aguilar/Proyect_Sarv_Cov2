package com.pe.covid.entity.services;

import java.util.List;

import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.stereotype.Service;

import com.pe.covid.entity.dao.ICiudadanoDao;
import com.pe.covid.entity.model.Ciudadano;

@Service
public class CiudadanoServiceImpl implements ICiudadanoService {

	@Autowired
	private ICiudadanoDao ciudadanoDao;

	@Override
	public Ciudadano get(int idciudadano) {
		return ciudadanoDao.findById(idciudadano).get();
	}

	@Override
	public List<Ciudadano> getAll() {
		return (List<Ciudadano>) ciudadanoDao.findAll();
	}

	@Override
	public void post(Ciudadano ciudadano) {
		ciudadanoDao.save(ciudadano);
	}

	@Override
	public void put(Ciudadano ciudadano, int idciudadano) {
		ciudadanoDao.findById(idciudadano).ifPresent((x) -> {
			ciudadano.setIdciudadano(idciudadano);
			ciudadanoDao.save(ciudadano);
		});
	}

	@Override
	public void delete(int idciudadano) {
		ciudadanoDao.deleteById(idciudadano);
	}

}
