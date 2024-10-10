# Practica_2_II
Práctica 2 de la asignatura Interfaces Inteligentes. En esta práctica se profundiza en el uso de scripts en Unity, realizando una serie de 8 ejercicios diferentes con el objetivo de aprender a programar con los elementos básicos de Unity.

## Ejercicio 1
El script cambia el color de un objeto cada 120 frames. Inicializa un vector de 3 valores aleatorios como color, y cada 120 frames modifica uno al azar, aplicando el nuevo color al objeto mediante el componente Renderer. El tiempo de espera entre cambios es configurable desde el inspector.
![Practica_2_II-SampleScene-Windows_-Mac_-Linux-Unity-2023 2 20f1_-_DX11_-2024-10-11-00-25-19](https://github.com/user-attachments/assets/d7b0c7f9-3763-4872-b6ff-afe4416bde66)

## Ejercicio 2
Este script imprime en la consola el nombre del objeto al que está asociado. Cuando la escena se ejecuta, el método Start() muestra el nombre del objeto usando Debug.Log(). Se usa en una escena simple con un plano y tres objetos (cubo, esfera y cilindro), cada uno con un color diferente.
![Practica_2_II-SampleScene-Windows_-Mac_-Linux-Unity-2023 2 20f1_-_DX11_-2024-10-11-00-33-03](https://github.com/user-attachments/assets/b92a8e5e-b119-4654-8263-8f7d7ae2be6b)

## Ejercicio 3
Este script calcula y muestra en la consola la magnitud, el ángulo, la distancia entre dos vectores y cuál tiene mayor altura. Asocia dos Vector3 públicos a la esfera, cuyos valores se pueden ajustar en el inspector. En Start(), se inicializan los vectores, se calculan y se muestran los resultados. El script compara las componentes y de los vectores para determinar cuál está a mayor altura.
![Practica_2_II-SampleScene-Windows_-Mac_-Linux-Unity-2023 2 20f1_-_DX11_-2024-10-11-00-37-05](https://github.com/user-attachments/assets/db68c1d7-4dea-456f-8076-a27bedde58a0)

## Ejercicio 4
Este script muestra en la consola el vector de posición de la esfera al inicio de la ejecución. Utiliza el componente Transform para acceder a la propiedad position del objeto y la imprime en el método Start().
![Practica_2_II-SampleScene-Windows_-Mac_-Linux-Unity-2023 2 20f1_-_DX11_-2024-10-11-00-39-54](https://github.com/user-attachments/assets/7fdae596-b6eb-4597-b198-8138a136802f)

## Ejercicio 5
Este script, asociado a la esfera, muestra en la consola la distancia entre la esfera y otros dos objetos: el cubo y el cilindro. Utiliza GameObject.FindWithTag para encontrar ambos objetos por sus etiquetas, y luego calcula la distancia entre sus posiciones usando Vector3.Distance en el método Start().
![Practica_2_II-SampleScene-Windows_-Mac_-Linux-Unity-2023 2 20f1_-_DX11_-2024-10-11-00-44-38](https://github.com/user-attachments/assets/d9812052-f1df-4ec1-a2b1-dca8c55781c7)

## Ejercicio 6
Este script desplaza tres objetos en la escena cuando el usuario presiona la barra espaciadora. Cada objeto tiene un vector de desplazamiento, configurable desde el inspector, que se aplica a su posición actual. En Update(), si se detecta que la barra espaciadora ha sido pulsada, el script modifica la posición de los objetos sumando el desplazamiento configurado para cada uno.
![Practica_2_II-SampleScene-Windows_-Mac_-Linux-Unity-2023 2 20f1_-_DX11_-2024-10-11-00-51-51](https://github.com/user-attachments/assets/360d9981-0abc-4ef8-9148-bf88eae17a3f)

## Ejericio 7
Este script cambia el color del cubo cuando se presiona la tecla "C" y el color del cilindro cuando se presiona la flecha arriba. Utiliza GameObject.FindWithTag para encontrar ambos objetos, obtiene su material a través del componente Renderer, y luego cambia sus colores de forma aleatoria en respuesta a las teclas presionadas en el método Update().
![Practica_2_II-SampleScene-Windows_-Mac_-Linux-Unity-2023 2 20f1_-_DX11_-2024-10-11-00-54-15](https://github.com/user-attachments/assets/530721f0-4681-4e5d-8ec5-03a2e75b4b72)

## Ejercicio 8
Este script aumenta la altura de la esfera del grupo 2 más cercana al cubo y cambia el color de la esfera más lejana al cubo cuando se pulsa la barra espaciadora. El script busca las esferas por sus etiquetas de tipo 1 y tipo 2, calcula las distancias al cubo y determina cuál es la más cercana y la más lejana. Luego, aumenta la altura de la esfera más cercana y cambia el color de la más lejana al pulsar la barra espaciadora.
![Practica_2_II-SampleScene-Windows_-Mac_-Linux-Unity-2023 2 20f1_-_DX11_-2024-10-11-01-01-21](https://github.com/user-attachments/assets/219e23ea-793b-43f9-98c0-ead2b4d5ed64)


