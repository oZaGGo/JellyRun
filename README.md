# JellyRun
<img width="400" height="400" alt="title" src="https://github.com/user-attachments/assets/55728c53-be37-4b01-b339-c3f23e987983" />

Un juego donde una pequeña gelatina tendrá que escapar de un pozo de lava por una tuberia. Para hacerlo un poco mas complicado... el movimiento es bastante rapido y la lava te perseguirá mas rápido conforme pase el tiempo.
El foco principal del juego es la rapidez y la fluidez del movimiento.

## Movimiento

- El salto en este juego se controla con un pequeño collider abajo del jugador:

<img width="415" height="175" alt="image" src="https://github.com/user-attachments/assets/e1130bb2-a31f-405b-b675-9f0ee7267062" />


Adicionalmente hay un pequeño delay en el salto para evitar errores o inputs que no corresponden al pulsar el espacio demasiado rapido.

- En este juego he implementado la mecanica del walljump empleando colliders:

<img width="726" height="640" alt="image" src="https://github.com/user-attachments/assets/282c662b-d8a8-4e57-aba8-91e9fa9cded5" />


Cuando chocas con un muro te quedas pegado y bajas muy despacio.

- Tambien hice pequeñas mejoras en el movimiento. Por ejemplo, hice unos pequeños colliders que detectan si te vas a comer una plataforma y se mueve un poco para evitar el fallo:

<img width="486" height="272" alt="image" src="https://github.com/user-attachments/assets/2934db88-70e8-4742-9b3b-c9f381d4d6ab" />


Si el personaje, por ejemplo, conectase con el borde derecho de una plataforma al saltar, el script y collider que impiden que te choques, te moveran un poquito hacia la derecha.

## Obstaculos

El principal obstaculo es la lava pero tambien hay pinchos y sierras que pueden matarte de un solo toque:

<img width="507" height="365" alt="image" src="https://github.com/user-attachments/assets/23978412-fe8d-47a1-8fce-dc1790e61692" />

## Mejoras

En general he intentado hacer un juego simple pero pulido, con animaciones que se sientan fluidas y pequeñas mejoras en el gameplay. Tenia planeado hacer un pequeño efecto de gotas de lava que caigan desde arriba del nivel y algun nivel mas pero por temas de tiempo se queda asi. Otra mejora interesante seria hacer mas enfasis en la caida y no tanto en la subido con algun nivel enfocado en hacer walljumps controlados hacia abajo.

## Gameplay

La idea principal es aprenderte el nivel y intentar hacerlo lo mas rapido posible. Un pequeño ejemplo de como se ve el juego en accion:

https://github.com/user-attachments/assets/9163c200-6c8a-46db-a79a-8c3b2cb97bbd


