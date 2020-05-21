package com.pe.covid.entity.dao;

import org.springframework.data.repository.CrudRepository;

import com.pe.covid.entity.model.Ciudadano;

public interface ICiudadanoDao extends CrudRepository<Ciudadano, Integer> {

}
