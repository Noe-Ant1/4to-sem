import java.util.Scanner;

public class Operador{

	private int tipoOperador; 
	 
	public int tipoOperador(String tipo){
		tipoOperador = 0;
		switch(tipo){
			case "^": 
				tipoOperador = 6;
				break;
			case "/": 
				tipoOperador = 5;
				break; 
			case "*": 
				tipoOperador = 4;
				break;
			case "+": 
				tipoOperador = 3;
				break;
			case "-": 
				tipoOperador = 2;
				break;
			case "=": 
				tipoOperador = 1;
				break;
		}
		return tipoOperador;
	}
	public boolean esOperadorValido(String cad) {
		int operador = tipoOperador(cad);
		boolean resultado = false;
		if (operador != 0) {
			resultado = true;
		}
		return resultado;
	}
}
