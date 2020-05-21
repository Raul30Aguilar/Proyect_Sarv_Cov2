package com.pe.covid.entity.controller;

import java.util.List;

import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.web.bind.annotation.DeleteMapping;
import org.springframework.web.bind.annotation.GetMapping;
import org.springframework.web.bind.annotation.PathVariable;
import org.springframework.web.bind.annotation.PostMapping;
import org.springframework.web.bind.annotation.PutMapping;
import org.springframework.web.bind.annotation.RestController;

import com.pe.covid.entity.model.Ciudadano;
import com.pe.covid.entity.services.ICiudadanoService;

@RestController
public class CiudadanoController {

	@Autowired
	ICiudadanoService ciudadanoService;

	@GetMapping("/ciudadano")
	public List<Ciudadano> getCiudadanos() {
		return ciudadanoService.getAll();
	}

	@GetMapping("/ciudadano/{idciudadano}")
	public Ciudadano getOne(@PathVariable(value = "idciudadano") int idciudadano) {
		return ciudadanoService.get(idciudadano);
	}

	@PostMapping("/ciudadano")
	public void add(Ciudadano ciudadano) {
		ciudadanoService.post(ciudadano);
	}

	@PutMapping("/ciudadano/{idciudadano}")
	public void update(Ciudadano ciudadano, @PathVariable(value = "idciudadano") int idciudadano) {
		ciudadanoService.put(ciudadano, idciudadano);
	}

	@DeleteMapping("/ciudadano/{idciudadano}")
	public void update(@PathVariable(value = "idciudadano") int idciudadano) {
		ciudadanoService.delete(idciudadano);
	}
}
