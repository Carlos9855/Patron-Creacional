# Patrón Creacional


El código resuelve el problema de la creación de instrumentos musicales utilizando **Factory Method** y con una **Instrument Factory**. 

Se tienen tres tipos de instrumentos: guitarra y piano, Bajo. Ambos instrumentos implementan una Interfaz **IInstrument** que contiene los métodos **Play()** y **Sell()**

Se hico correr un analisis exploratorio del codigo con la aplicacion de SonarQube y se encontro que habia dos Code Smells como se muestra en la imagen.
![Code_Smells](https://user-images.githubusercontent.com/73244043/137568244-a2966ee7-1dad-4b59-ad6c-d0a95a17049a.png)

Despues de la correxion de los Code Smells se realizo el mismo analisis y en el no se encontro ningun Code Smell.
![Code_Smells_fixed](https://user-images.githubusercontent.com/73244043/137568247-ac297a1b-d20c-4e2b-9242-7a1e9d0d1072.png)
