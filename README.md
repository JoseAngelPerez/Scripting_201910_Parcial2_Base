# Scripting_201910_Parcial2_Base

Edite este archivo para responder el último enunciado del examen. No cree otro archivo.

Para empezar es necesario usar pooling, dado que se pide que los objetos no sean instanciados y luego destruidos de forma constante, lo cual conlleva que debe usarse este y no factory, ya que para el mismo habria de romperse esta caracteristica.
El singleton no es necesario ya que no se esta pidiendo ningun script que sea unico y al que deban tener acceso muchos otros, caso contrario se pidiera un score o un timer, pero no es el caso dado en el enunciado.
El decorator es innecesario ya que no se le va a agregar funcionalidad a ningun elemento del juego, por ejemplo en jugador va a usar la misma arma durante todo el juego, caso contrario si fuera necesario que cambiara o mejorar su arma.
El patron facade no es necesario ya que no se requiere simplificar el acceso a metodos entre clase, yaque de por si las clases son simples y un facade solo duplicaria funciones ya existentes, cosa que no es necesaria ya que se puede acceder a los mismos de forma directa, sin muchos problemas.
Flyweight no es necesario ya que los unicos que comparten una funcion en comin es el ia que explota al llegar al enemigo y el que le dispara, estos comparten la caraceristica de ditrijirse al jugador, pero solo comparten esta , por lo cual no considero que sea fundamental emplearla ya que solo es una.
El patron command podria ser utilizado para los botones y las funciones que estos ejecutan separando la logica de la ejecucion, pero ene el enunciado no de pide alterar algo en el sistema de controles, es innecesario hacer esto.
Los patrones obserever y estate los voy autilizar ambos para verificar cuando se encuentra cerca del ca de personaje (observer) y utilizare state para cambiar el comportamiento de los enemigos segun el observer.
