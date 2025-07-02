import java.util.Scanner;

public class Cola{
	
	int entrada, salida, tam; 
	String c1[]; //cola

	//constructor
	public Cola(int tam) {
		entrada = salida = 0;
		this.tam = tam;
		c1 = new String[tam];
	}
	
	//insertar 
	public void insertar(String x) {
		c1[entrada] = x;
		entrada++;
	}
	
	//extraer
	public String extraer() {
		String x;
		x = c1[salida];
		salida++;
		return x;
	}
	
	//vacío
	public boolean vacio() {
		if(entrada == salida){
			return true;
		}else{
			return false;
		}
	}
	
	//lleno
	public boolean lleno() {
		if(entrada == tam){
			return true;
		}else{
			return false;
		}
	}
	
	//mostrar datos
	public void mostrar() {
		for(int i = salida; i < entrada; i++) {
			System.out.println(c1[i]);
		}
	}
}
