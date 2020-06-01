package com.example.rest.servicios;

import javax.ws.rs.GET;
import javax.ws.rs.POST;
import javax.ws.rs.PUT;
import javax.ws.rs.Path;
import javax.ws.rs.PathParam;
import javax.ws.rs.Produces;
import javax.ws.rs.core.MediaType;
import javax.ws.rs.core.Response;

import org.apache.commons.logging.Log;
import org.apache.commons.logging.LogFactory;

import com.example.rest.dao.AddStatusCiuDao;
import com.example.rest.dao.AgregarTriajeDao;
import com.example.rest.dao.ListaUbigeoDao;
import com.example.rest.dao.ModiStatusCiudDao;

import om.example.rest.entidades.AddStatusCiu;
import om.example.rest.entidades.AgregarTriaje;
import om.example.rest.entidades.ListaUbigeo;
import om.example.rest.entidades.ModiStatusCiud;

//GET,POST,PUT,DELETE métodos del protocolo HTTP
// La tecnología rest utiliza estos cuatro métodos

@Path("/servicios")
public class ServicioRest {
	private static final Log log = LogFactory.getLog(ServicioRest.class);

	private AddStatusCiuDao daoAddStatusCiud = new AddStatusCiuDao();
	private ModiStatusCiudDao daoModiStatusCiu = new ModiStatusCiudDao();
	private AgregarTriajeDao daoTriaje = new AgregarTriajeDao();
	private ListaUbigeoDao daoUbigeo=new ListaUbigeoDao();

	/**
	 *Agrega el estado del Ciudadano
	 */
	@POST
	@Path("/agregarestadociudadano")
	@Produces({ MediaType.APPLICATION_JSON })
	public Response insertaEstadoCiudadano(AddStatusCiu obj) {
		System.out.println(obj);
		log.info("Agregar Estado Ciudadano");
		return Response.ok(daoAddStatusCiud.insertaEstadoCiudadano(obj)).build();
	}
	
	/**
	 *Modifica el estado del Ciudadano
	 */
	@PUT
	@Path("/modificarestadociudadano")
	@Produces({ MediaType.APPLICATION_JSON })
	public Response ModificarEstadoCiudadano(ModiStatusCiud obj) {
		System.out.println(obj);
		log.info("Modificar Estado Ciudadano");
		return Response.ok(daoModiStatusCiu.modificarEstadoCiudadano(obj)).build();
	}
	
	/**
	 *Agrega el Ciudadano y Triaje
	 */
	@POST
	@Path("/agregartriaje")
	@Produces({ MediaType.APPLICATION_JSON })
	public Response registrarTriaje(AgregarTriaje obj) {
		System.out.println(obj);
		log.info("Agregar Estado Ciudadano");
		return Response.ok(daoTriaje.registrarTriaje(obj)).build();
	}
	
	@GET
	@Path("/info")
	@Produces({ MediaType.APPLICATION_JSON })
	public Response info() {
		log.info("listarTodos rest ");
		return Response.ok("ok").build();
	}
}