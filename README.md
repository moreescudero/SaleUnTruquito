# Título: Un Truquito

## Resumen

La aplicación es un simulador del juego "Truco" online, donde se ingresa con un usuario único y una contraseña, en caso de no tener un usuario se pueden registrar.
Una vez adentro del menu principal del juego el usuario podrá:

* visualizar el top 5 de los mejores jugadores, un datagridview de las partidas que estan comenzando en ese momento y tiene 3 segundos para ingresar a la partida o esta
 comenzará y no podrá acceder a verla, al clickearlas se habilitará el botón de ver partida en donde podrá presenciar una partida entre dos jugadores. 

* entrar a sus estadísticas donde podrá ver sus partidas ganadas (junto con la fecha de las partidas y el jugador que haya perdido), como 
 también podrá ver la cantidad de partidas ganadas, perdidas, como un dato extra podrá visualizar la cantidad de anchos de espada que obtuvo cada vez que haya jugado y 
 la cantidad de veces que haya cantado "falta envido".

* visualizar las reglas del juego, mediante un botón que al presionarlo se abre un panel con las reglas y al volver a presionarlo el panel se cerrará


## Diagrama de clases



## Justificación técnica

### SQL

Se utiliza la base de datos para la persistencia de datos de los Usuarios y de las Partidas. De ese modo durante el programa se podrá obtener la información, agregar
nuevos Usuarios y/o Partidas y modificar los ya existentes.

### Excepciones

Se utilizan excepciones en varias partes del código en donde podría ocurrir un error en tiempo de ejecución o en errores del usuario como por ejemplo en el login donde 
se lanza una excepción controlada en caso de que el usuario o la contraseña sean incorrectos o cuando el usuario se registra, si el nombre de usuario que ingresa ya existe
entonces se lanzará una excepción  para informar mediante un label que el nombre ya existe.

### Unit Testing

Se hace una clase de Unit Testing por cada clase de Entidades.Modelo, comprobando que funcionen tanto por éxito como por fallo e incluso dependiendo el método también
se realizan pruebas unitarias de distintas variantes de éxito como de fallo.

### Generics

Se utiliza generics dentro de la calse Serializador con el funcionamiento de poder serializar y deserializar cualquier tipo de objeto.

### Serialización

Se utiliza la serialización para deserializar el mazo de cartas con el que se jugarán las partidas. 

### Escritura Archivos

Se utiliza la escritura de archivos para guardar el RichTextBox cada vez que termina una partida. Se le consulta al usuario si desea guardarlo y en caso de que acepte
se guardará un archivo de texto en el escriturio dentro de una carpeta llamada "Partida".

### Interfaces

Se utilizan las interfaces para desarrollar el modelo MVP con el propósito de dejar la lógica en las entidades y quitarla del formulario. De ese modo todas las clases 
se encuentran protegidas dentro de la biblioteca de clases y los presentadores mediante las interfaces son quienes se encargan de ser "intermediaros" entre la vista y el
modelo.

### Delegados

Se utilizan dentro del presentador PresentadorSala para activa los eventos de la partida y suscribirle los métodos propios de la finalización de la vuelta para un 
delegado y para el otro los propios de la finalización de la partida.

### Task

Se utiliza task para hacer posible la visualización de las partidas y que el juego funcione en distintas ventanas. 

### Eventos

Se utilizan eventos dentro de la clase Partida para accionar los métodos del mazo (Barajar, Repartir) y otro para la finalización de la partida que asigna puntos y 
reestablecer los valores de cada jugador
 
