/*
 * Created by SharpDevelop.
 * User: Alumno
 * Date: 21/09/2022
 * Time: 11:50
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using OpenTK;
using OpenTK.Input;
using OpenTK.Graphics.OpenGL;

namespace Practica7
{
	/// <summary>
	/// Description of Pantalla.
	/// </summary>
	public class Pantalla:GameWindow
	{
		Punto a,b,centro;
		Linea distancia;
		Circulo circulo,circulo2;
		//Tools herramientas=new Tools();
		
		public Pantalla(int ancho,int alto) : base(ancho,alto) // :base(ancho.alto)
		{
			Title="INPUT"; // <- Estos errores pasan cuando usas un teclado con proporcionesw distintas al tuyo 
			//Width=ancho;
			//Height=alto;
		}
		//Carga de datos
		protected override void OnLoad(System.EventArgs evento)
		{
			GL.ClearColor(1f, 1f, 1f, 1f);
			GL.MatrixMode(MatrixMode.Projection);
			GL.Ortho(0,600,0,600,-1,1);
			
			a=new Punto(230,230);
			b=new Punto(360,360);
			circulo=new Circulo();
			//circulo.arco(0,Math.PI*2);
			centro=new Punto(300,300);
			circulo.Radio=50;
			circulo.Centro=a;
			circulo.setColor(0,0,0);
			
			circulo2= new Circulo();
			circulo2.Centro=b;
			circulo2.Radio=50;
			circulo2.setColor(0,0,0);
			distancia=new Linea();
			

		}
		//Actualizar datos
		protected override void OnUpdateFrame(FrameEventArgs e){
			//base.OnUpdateFrame(e);
			GL.Clear(ClearBufferMask.ColorBufferBit); //Limpiar Buffer	
			//a.set(aleatorio.NextDouble(), aleatorio.NextDouble());
			//a.PuntoRGB((float)aleatorio.NextDouble(),(float)aleatorio.NextDouble(),(float)aleatorio.NextDouble());
			//linea.setColor(0.8f,0f,0f);
			//circulo.Radio=(b.X+=0.01)
		}
		//Mostrar datos
		protected override void OnRenderFrame(FrameEventArgs evento){
			//base.OnRenderFrame(e);
			//linea.dibujarP(b,c);
			
			//circulo.draw();
			circulo.draw(a,50);
			circulo.draw(b,50);
			distancia.setColor(1,0,0);
			distancia.ddaC(a,b);
			//circulo.draw();
			SwapBuffers();
		}
		
		protected override void OnKeyPress(KeyPressEventArgs e)
		{
			if(e.KeyChar=='q'){Exit();}
			int radioT=(int)Math.Floor(circulo.Radio+circulo2.Radio);
			if(circulo.Radio+circulo2.Radio<=distancia.calcularLongitud())
			{
				if(e.KeyChar=='a'||e.KeyChar=='A'){a.X-=5;}
				if(e.KeyChar=='S'||e.KeyChar=='s'){a.Y-=5;}
				if(e.KeyChar=='W'||e.KeyChar=='w'){a.Y+=5;}
				if(e.KeyChar=='D'||e.KeyChar=='d'){a.X+=5;}			
			}
			
			if(circulo.Radio+circulo2.Radio>=distancia.calcularLongitud())
			{
				Console.WriteLine("estan pegados");
				Console.WriteLine();
				if(e.KeyChar=='a'||e.KeyChar=='A')
				{
					a.X-=5;
					if(circulo.Radio+circulo2.Radio>=distancia.calcularLongitud()){a.X+=5;}
				}
				if(e.KeyChar=='S'||e.KeyChar=='s')
				{
					a.Y-=5;
					if(circulo.Radio+circulo2.Radio>=distancia.calcularLongitud()){a.Y+=5;}
				}
				if(e.KeyChar=='W'||e.KeyChar=='w')
				{
					a.Y+=5;
					if(circulo.Radio+circulo2.Radio>=distancia.calcularLongitud()){a.Y-=5;}
				}
				if(e.KeyChar=='D'||e.KeyChar=='d')
				{
					a.X+=5;
					if(circulo.Radio+circulo2.Radio>=distancia.calcularLongitud()){a.X-=5;}
				}
			}

		}
		
		protected override void OnMouseMove(MouseMoveEventArgs e)
		{
			/*double Xorig=a.X;
			double Yorig=a.Y;
			a.set(e.X,this.Height-e.Y);
			if(circulo.Radio+circulo2.Radio>distancia.calcularLongitud())
			{
				a.set(Xorig,Yorig);
			}
			*/
			
		}
		
	}
}
