#  "Aplicación de principios y arquitecturas de sistemas hipermedia"
## Link Video
https://udlaec-my.sharepoint.com/:v:/g/personal/mateo_encalada_udla_edu_ec/EYDBEiF8P0VBvV6hEkH0iEYBfrtkOugounPTXVU5_pupmw?e=Bh7yKf&nav=eyJyZWZlcnJhbEluZm8iOnsicmVmZXJyYWxBcHAiOiJTdHJlYW1XZWJBcHAiLCJyZWZlcnJhbFZpZXciOiJTaGFyZURpYWxvZyIsInJlZmVycmFsQXBwUGxhdGZvcm0iOiJXZWIiLCJyZWZlcnJhbE1vZGUiOiJ2aWV3In19
## Lista de Features usados en el proyecto 
1:Manejo de escenas
2: FPS
3: Vida en los enemigos
4: Enemigo detecta jugador dependiendo el rango del mismo
5:Animaciones
6:Sonidos 
7: Agarrar objetos 
8: Cambio de escenas mediante un collider.
9: Activar objetos cuando se cumpla una condicion
10: Spawnear enemigos aleatoriamente(Con limite de enemigos creados y con tiempo entre creacion de enemigos)
11: Destruir un objeto al entrar en contacto con otro y añadir un contador en canva.
12. Drop de item caundo se elimina un objeto

## En funicon para entnder cada funcionalidad del proyecto estar explicando cada Script y que hace cada uno
## Manjeo de escenas 
Dentro del proyecto se encuentra una carpeta Scenes dentro de esta se puede encontrar que existen varias escenas 
donde las usadas son "MainGame","Menu","Win" en funcion de lograr interactuar con ellas en el menu File del proyecto
existe una opcion llamada build settings donde debemos agregar todas las escenas que se van a hacer uso en el juego.
En esta escena principal se crea un objeto vacio donde esta conectado con el Script Menu (Revisar dentro de los archivos para ver el menu)
Este Script hace uso de "using UnityEngine.SceneManagement" para poder manejar el cambio de escenas.
## Cambio de escenas mediante un collider.
En el objeto que queremos que sea el que se encargue del cambio de escena mediante el contacto deberemos ingresar el script en este caso se llama Neext Lvl
(Revisar dentro de los archivos para ver Script) En este Script se encuentra el metodo "OnTriggerEnter" Que es el que se encarga de reconocer que el objeto 
que entra en contacto con este sea uno especifico y no cualquiera.
## Agarrar Objetos
Este es el Feature mas complejo, en nuestro objeto de jugador deberos poner este Script llamado "PhysicsPickup"(Revisar dentro de los archivos para ver Script) Este Script necesita un Objeto de referencia dentro de nuestro personaje para ver donde sera el lugar donde se va a recojer el objeto, dentro del script se declara una tecla que sea la encargada de activar el script. En este se usa Ray para detectar donde este mirando el juagor y poder levantar el objeto. En el metodo Update se encutra un if que es el encargado de mantener el objeto elevado hasta que el jugador lo suelte.
Los objetos que pueden ser levantados necesitaran un layer activado en este, en este caso se creo un Layer "Pickup" Este Layer nuevo debera ir referenciado en el Script en la Parte que esta descrita como Pickup Mask y en la referencia de Pickup Target debera ir nuestro objeto que usaremos de referencia para mostrar el objeto levantado en este caso sera el objeto vacio creado dentro prefab de jugador.
## Vida enemigos y Drop de item al ser destruidos
Todos nuestro enemigos estaran conectados con nuestro Script Target (Revisar dentro de los archivos para ver Script) Dentro de este representa un objetivo que puede recibir daño y ser destruido gracais a la variable health donde esta tiene un metodo take damage que esta relacionada con el Script gun para que puedan interactuar entre estos. Existe un metodo Die que es el encargado de de destruir el objeto al igual que tiene un metodo DropItem que es el encargado de instanciar un objeto para que aparezca.
##Spawnear enemigos 
Este feature esta relacionado con el Script "SpawnerTimer"(Revisar dentro de los archivos para ver Script) este Script esta conectado a un objeto vacio ubicado en cualquier posicion del mundo ya que la ubicacion de donde se spawnean se realiza mediante codigo. Al ser un poco complejo el script lo explicare de una forma mas especifica. 
Este código es un spawner en Unity que genera enemigos a intervalos regulares y los gestiona mientras están activos en la escena. Aquí está su funcionamiento:
Declaraciones iniciales:
enemyPrefab: Almacena el GameObject que se generará como enemigo.
spawnInterval: Determina el tiempo entre cada generación de enemigos.
maxEnemies: Define el límite máximo de enemigos permitidos en la escena al mismo tiempo.
spawnedEnemies: Una lista que contiene todos los enemigos generados actualmente.
Método Update():
Incrementa el temporizador timer basado en el tiempo real.
Cuando el temporizador alcanza el intervalo de generación (spawnInterval) y la cantidad de enemigos generados es menor que el límite (maxEnemies), llama al método SpawnEnemy() para generar un nuevo enemigo.
Método SpawnEnemy():
Calcula una posición de generación aleatoria dentro de un rango especificado.
Instancia un nuevo enemigo (enemyPrefab) en esa posición.
Agrega el enemigo a la lista de enemigos generados (spawnedEnemies).
Registra el método HandleEnemyDestroyed como un delegado para el evento OnEnemyDestroyed del componente Target del nuevo enemigo.
Método HandleEnemyDestroyed():
Comprueba si el enemigo destruido existe y está en la lista de enemigos generados.
Si es así, elimina el delegado HandleEnemyDestroyed del evento OnEnemyDestroyed del enemigo destruido.
Luego, elimina ese enemigo de la lista de enemigos generados.
Este script básicamente genera enemigos en intervalos de tiempo regulares siempre que la cantidad actual de enemigos en la escena sea menor que el límite establecido. Además, administra la lista de enemigos generados y elimina correctamente los enemigos destruidos de esta lista cuando se destruyen en la escena.



