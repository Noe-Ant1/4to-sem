import java.util.Scanner;


public class PricipalCola {
	
	public static void main(String[] args) {
		
		String cad = "";
		boolean operador;
		int aux;
		
		Cola colaEnt = new Cola(15);
		Cola colaSal = new Cola(15);
		Pila pilaOpe = new Pila(15);
		Operador ope = new Operador();
		
		colaEnt.insertar("x");
		colaEnt.insertar("=");
		colaEnt.insertar("5");
		colaEnt.insertar("+");
		colaEnt.insertar("8");
		colaEnt.insertar("/");
		colaEnt.insertar("2");
		colaEnt.insertar("-");
		colaEnt.insertar("7");
		colaEnt.insertar("*");
		colaEnt.insertar("4");
		colaEnt.insertar("+");
		colaEnt.insertar("6");
		
		for (int i = 0; i < colaEnt.entrada; i++) {
			cad = colaEnt.extraer();
			operador = ope.esOperadorValido(cad);
			if (operador) {
				pilaOpe.insertar(cad);
			} else {
				colaSal.insertar(cad);
			}


		}

		System.out.println("Pila operadores:");
		pilaOpe.mostrar();
		System.out.println("Cola salida:");
		colaSal.mostrar();
	}
}

