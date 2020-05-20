package com.pe.covid.entity.services;

import java.util.List;

import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.stereotype.Service;

import com.pe.covid.entity.dao.IUsuarioDao;
import com.pe.covid.entity.model.Usuario;

@Service
public class UsuarioServiceImpl implements IUsuarioService{
	@Autowired
	private IUsuarioDao usuarioDao;
	
	@Override
	public Usuario get(int idusuario) {
		return usuarioDao.findById(idusuario).get();
	}

	@Override
	public List<Usuario> getAll() {
		return (List<Usuario>) usuarioDao.findAll();
	}

	@Override
	public void post(Usuario usuario) {
		usuarioDao.save(usuario);
	}

	@Override
	public void put(Usuario usuario, int idusuario) {
		usuarioDao.findById(idusuario).ifPresent((x)->{
			usuario.setIdusuario(idusuario);
			usuarioDao.save(usuario);
		});
	}
	@Override
	public void delete(int idusuario) {
		usuarioDao.deleteById(idusuario);
	}

}
