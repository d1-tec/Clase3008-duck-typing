class Persona {
  saludar() {
    console.log('Soy una persona');
  }
}


class Perro {
  saludar() {
    console.log('Soy un perro');
  }
}

class Gato {

}

// no me interesa de que tipo es julio
// me interesa que julio sepa saludar
function saludarEntidad(julio) {
  julio.saludar();
}

const persona = new Persona();
const perro = new Perro();
const gato = new Gato();

saludarEntidad(persona);
saludarEntidad(perro);
saludarEntidad(gato);

/*

Los lenguajes como JS son debilmente tipados, por lo que podemos hacer duck typing
DUCK TYPING = no me interesa el tipo de la variable, me interesa a que metodos responde la variable

*/
