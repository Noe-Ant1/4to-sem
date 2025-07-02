import java.util.Scanner;

public class Pila{
	
	String p1[]; //vector
	int tope; //para saber en qué posición está
	//int tamanio = p1.length - 1;
	
	//constructor
	public Pila(int tamanio) {
		p1 = new String[tamanio];
		tope = 0;
	}
	
	//insertar 
	public void insertar(String dato) {
		if (tope <= (tamanio() - 1)) {
			p1[tope] = dato;
			tope++;
		}else{
			System.out.println("La pila está llena.");
		}
	}
	
	//eliminar
	public String eliminar() {
		String eliminar = "";
		if(tope == 0){
			System.out.println("La pila esta vacia.");
		}else{
			tope--;
			eliminar = p1[tope];
		}
		return eliminar;
	}
	
	//vacío
	public boolean vacio() {
		if(tope == 0){
			return true;
		}else{
			return false;
		}
	}
	
	//lleno
	public boolean lleno() {
		if(tope == tamanio()){
			return true;
		}else{
			return false;
		}
	}
	
	//tamaño
	public int tamanio() {
		//System.out.println("tamanio = " + p1.length + "," + (p1.length-1));
		return p1.length;
	}
	
	//mostrar datos
	public void mostrar() {
		for(int i=(tope-1); i>=0; i--) {
			System.out.println(p1[i]);
		}
	}
	
	//suma de pilas
	public void suma(Pila a, Pila b) {
		if(a.vacio() == true || b.vacio() == true) {
			//System.out.println("No se ha podido realizar la suma.");
		}else{
			for(int i=0; i<tamanio(); i++) {
				p1[i] = a.p1[i] + b.p1[i];
			}
				tope = tamanio();
		}
	}
}
