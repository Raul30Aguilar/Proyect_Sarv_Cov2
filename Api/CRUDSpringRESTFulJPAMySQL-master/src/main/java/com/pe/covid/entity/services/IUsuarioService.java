package com.pe.covid.entity.services;

import java.util.List;

import com.pe.covid.entity.model.Usuario;

public interface IUsuarioService {

		public Usuario get(int idusuario);
		public List<Usuario> getAll();
		public void post(Usuario usuario);
		public void put(Usuario usuario, int idusuario);
		public void delete(int idusuario);
		
}
