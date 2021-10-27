//Aixo es el esquelet de les clases i els atributs.
	// Falten els metodes getters i setters, mirar el tema5 com se possen que aci no els he possat
		//per a estalviar.
		//Orden: ApHora, Aula, profesor, asignatura, grupo

public class ApHora{
	private ICollection<Asignatura> l_asignatures
	private ICollection<Profesor> l_profesores

	public ApHora(){
		this.l_asignatures=new List<Asignatura>();	//Relajar
		this.l_profesores=new List<Profesor>();	//Relajar
	}

}

public class Asignatura{
	private String nombre
	private int codigo
	private String curso
	private ApHora ref_apH
	private ICollection<Profesor> l_profesores
	private ICollection<Teoria>	l_grupo_teoria
	private ICollection<Practica> l_grupo_practica
	
	//Constructor
	public Asignatura (String nombre, int codigo, String curso, ApHora ref_apH, ICollection<Profesor> l_profesores){
			this.nombre=nombre;
			this.codigo=codigo;
			this.curso=curso;
			this.ref_apH=ref_apH;
			this.l_profesores=l_profesores;
			this.l_grupo_teoria=new List<Teoria>();	//Relajar
			this.l_grupo_practica=new List<Practica>();
		}
	
}

public class Profesor{
	private String nombre
	private int codigo
	private ApHora ref_apH
	private ICollection<Asignatura> l_asignatures
	private ICollection<Grupo>	l_grupo
	
	//Constructor
	public Profesor (String nombre, int codigo, ApHora ref_apH){
			this.nombre = nombre;
			this.codigo = codigo;
			this.ref_apH = ref_apH;			
			this.l_asignatures=new List<Asignatura>();	//Relajar
			this.l_grupo=new List<Grupo>();		//Relajar
		}
	
}

public abstract class Grupo{	//Esta clase es abstracta
	private int cod_g
	private int tamaño
	private Profesor ref_profesor
	private Aula ref_aula 
	private String franja_horaria
	
	//Constructor
	public Grupo(int cod_g, int tamaño, Profesor ref_profesor, 
		Aula ref_aula, String franja_horaria){
		this.cod_g=cod_g;
		this.tamaño=tamaño;
		this.ref_profesor=ref_profesor;
		this.ref_aula=ref_aula;
		this.franja_horaria = franja_horaria;
	}

}

public class Teoria:Grupo{
	private Asignatura ref_asignatura
	
	//Constructor
	public Teoria(int cod_g, int tamaño, Asignatura ref_asignatura){
		this.cod_g=cod_g
		this.tamaño=tamaño
		this.ref_asignatura=ref_asignatura
	}

}

public class Practica:Grupo{
	private Asignatura ref_asignatura

	//Constructor
	public Practica(int cod_g, int tamaño, Asignatura ref_asignatura){
		this.cod_g=cod_g
		this.tamaño=tamaño
		this.ref_asignatura=ref_asignatura
	}

}


public class Aula{
	private String cod_a
	private int capacidad
	private ICollection<Grupo> l_grupo
	
	//Constructor
	public Aula(String cod_a, int capacidad){
		this.cod_a = cod_a;
		this.capacidad = capacidad
		l_grupo= new List<Grupo>();
	}

}