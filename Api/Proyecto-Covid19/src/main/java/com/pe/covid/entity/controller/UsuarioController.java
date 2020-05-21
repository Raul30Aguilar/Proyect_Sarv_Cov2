package com.pe.covid.entity.controller;

import java.util.List;

import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.web.bind.annotation.DeleteMapping;
import org.springframework.web.bind.annotation.GetMapping;
import org.springframework.web.bind.annotation.PathVariable;
import org.springframework.web.bind.annotation.PostMapping;
import org.springframework.web.bind.annotation.PutMapping;
import org.springframework.web.bind.annotation.RestController;

import com.pe.covid.entity.model.Usuario;
import com.pe.covid.entity.services.IUsuarioService;

@RestController
public class UsuarioController {

	@Autowired
	IUsuarioService usuarioService;

	@GetMapping("/usuario")
	public List<Usuario> getUsuarios() {
		return usuarioService.getAll();
	}

	@GetMapping("/usuario/{idusuario}")
	public Usuario getOne(@PathVariable(value = "idusuario") int idusuario) {
		return usuarioService.get(idusuario);
	}

	@PostMapping("/usuario")
	public void add(Usuario usuario) {
		usuarioService.post(usuario);
	}

	@PutMapping("/usuario/{idusuario}")
	public void update(Usuario usuario, @PathVariable(value = "idusuario") int idusuario) {
		usuarioService.put(usuario, idusuario);
	}

	@DeleteMapping("/usuario/{idusuario}")
	public void update(@PathVariable(value = "idusuario") int idusuario) {
		usuarioService.delete(idusuario);
	}
}
