Projekt Library

1.	Aby zainicjalizować bazę danych wraz z zestawem danych proszę otworzyć plik library.sql
w programie sql server management studio, a następnie wykonać skrypt 
( należy zwrócić uwagę na to aby ścieżka była poprawna FILENAME = …  )
![image](https://user-images.githubusercontent.com/101005328/219758891-7a3c8aeb-1c62-42f8-9274-3c8619ea7ebe.png)

2.	Następnie należy otworzyć projekt oraz ustawić odpowiedni connection string 
![image](https://user-images.githubusercontent.com/101005328/219758874-6eb756d2-4904-439e-9c6c-5e797327c07a.png)

3.	Kolejnym krokiem będzie uruchomienie projektu  
![start](https://github.com/MatMal00/OnionLibrary/assets/101005328/348c8d56-6b49-42c2-9cec-3eb9dc85b686)

•	Należy zwrócić szczególną uwagę na to aby backend uruchamiał się jako pierwszy
 ![order](https://github.com/MatMal00/OnionLibrary/assets/101005328/a6587cb9-029b-44ce-ae47-eeae0492cfb9)

4.Po wykonaniu się pomyślniej kompilacji otworzą się nam okienka z dokumentacja backendu oraz aplikacja frontowa:

 •  swagger – dokumentacja wszystkich dostępnych endpointów w aplikacji
 
 ![result](https://github.com/MatMal00/OnionLibrary/assets/101005328/4c2498c7-131c-4be2-ba03-172cdde928ea)

 •	aplikacja frontowa

![image](https://user-images.githubusercontent.com/101005328/219758774-67642ed1-ea98-4f86-ae08-e150db86a755.png)

5. 5.	W aplikacji są dostępne dwa typu użytkowników (admin oraz user)
•	Admin – usuwanie, edycja książek oraz przeglądanie książek
 
 - email: admin@admin.pl hasło: test123
 
•	User – możliwość składania zamówień oraz przeglądania książek
 
 - email: testuser@user.pl hasło: test123
 ![image](https://user-images.githubusercontent.com/101005328/219804825-fa9fa0fe-191c-48b3-85f0-e6ef0a3f49ee.png)
 ![image](https://user-images.githubusercontent.com/101005328/219804838-d655e6e6-f691-41e4-a33c-9658494e62a9.png)
 ![image](https://user-images.githubusercontent.com/101005328/219805161-ddea98c1-34a5-4cfb-a27d-8df875337dac.png)
 ![image](https://user-images.githubusercontent.com/101005328/219805213-8ecc0959-cef4-4843-884a-7a4f30c74611.png)


Diagram bazy daynch:


![image](https://user-images.githubusercontent.com/101005328/219760658-b7e7fb7a-64de-40f4-a2af-a91d6cbd5a00.png)


Autorzy:
Mateusz Malec, Patryk Łuszcz
