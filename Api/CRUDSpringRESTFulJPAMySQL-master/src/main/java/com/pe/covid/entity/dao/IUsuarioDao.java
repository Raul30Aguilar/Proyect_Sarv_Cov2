package com.pe.covid.entity.dao;

import org.springframework.data.repository.CrudRepository;

import com.pe.covid.entity.model.Usuario;

public interface IUsuarioDao extends CrudRepository<Usuario, Integer>{

}
