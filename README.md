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
