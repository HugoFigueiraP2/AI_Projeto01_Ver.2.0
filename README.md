# Projecto 1 de Inteligência Artificial

## Autores:
- Hugo Silva a22001815
- Leonor Figueiredo a21902968

## Quem fez o que
- Hugo: Código do Spawner, terminou o código dos agentes e ajudou no relatório.
- Leonor: Código inicial dos agentes, layout do nível, relatório, código da explosão.

## Introdução
O objectivo deste trabalho foi analisar o comportamento uma hipotética muldidão de pessoas num concerto, onde uma explosões ou várias explosões irão ocorrer. 
Para tal, o grupo recorreu à Inteligência Artificial ou Agent-Based Simultion, que consiste na criação de agentes que irão replicar comportamentos humanos ou, o mais humanos que a programação deles permitir. Estes agentes irão ajudar o grupo a simular o comportamento das pessoas durante um concerto, o ir para perto do palco ouvir música, ir para as zonas de restauração ou de descanso. E também, durante o momento de pânico. A morte delas, o correr para as saidas, o comportamento daquelas que ficam feridas. É atraves destes agentes que por vezes, as pessoas conseguem prever como é que certas situações irão desenrolar-se. É atraves destes agentes que se pode evitar situações de crowd crushing ou crowd surge, momentos que podem levar pessoas à morte durante os alturas de pânico. Ao analisar estes agentes e estas simulações computarizadas, os especialistas podem desenvolver estruturas com multiplas saidas para evitar que as pessoas se esmaguem umas às outras na altura de fugir, zonas seguras em alturas de atentados para proteger as pessoas e sobretudo, zonas com amplo espaço. Espaços amplos ajudam a diminuir a densidde populacional por metro quadrado, o que também ajudará a diminuir o risco de crowd crush durante os momentos de pânico. 
E é com este trabalho, que o nosso grupo pertende descobrir como é que os especialistas chegam a estas conclusões.

## Metodologia
A simulação foi feita em 3D. Os agentes, que são 383 têm movimento cinemático, ou seja, avançam com uma velocidade constante e até ao objectivo. Para activar as explosões, usamos o rato, pressionando o botão esquerdo na área desejada. Usamos Decision Trees para que os agentes determinassem o seu objectivo e ações. Consuante os valores da food, stamina e speed (nome que usamos na nossas variaveis), o destino dos nossos agentes mudaria. Inicialmente, a maioria, encaminharia-se para os palcos, porém, alguns agentes já poderia começar com a food e stamina baixa e, então, encaminhariam-se para as zonas restauração e zonas verdes. Contudo, os agentes também vão perder food e stamina à medida que o tempo vai passando. Quando isso acontece, esses agentes irão para as zonas verdes ou restauração para recuperarem o valor da variavel que perderam. Após recuperarem esses valores, irão direcionar novamente para um dos palcos.

![Diagram UML dos agentes](https://images-wixmp-ed30a86b8c4ca887773594c2.wixmp.com/f/2fb39435-99ff-49ad-9246-42032eeea416/df47lvn-f5e4bbbf-6828-4e99-8910-ef7d87eb56eb.png?token=eyJ0eXAiOiJKV1QiLCJhbGciOiJIUzI1NiJ9.eyJzdWIiOiJ1cm46YXBwOjdlMGQxODg5ODIyNjQzNzNhNWYwZDQxNWVhMGQyNmUwIiwiaXNzIjoidXJuOmFwcDo3ZTBkMTg4OTgyMjY0MzczYTVmMGQ0MTVlYTBkMjZlMCIsIm9iaiI6W1t7InBhdGgiOiJcL2ZcLzJmYjM5NDM1LTk5ZmYtNDlhZC05MjQ2LTQyMDMyZWVlYTQxNlwvZGY0N2x2bi1mNWU0YmJiZi02ODI4LTRlOTktODkxMC1lZjdkODdlYjU2ZWIucG5nIn1dXSwiYXVkIjpbInVybjpzZXJ2aWNlOmZpbGUuZG93bmxvYWQiXX0.4VzC6-jiC2Kt918-gPCTPmuLFovIXzDI6QKZnrrENzA)

Diagrama UML dos agentes que foi criado

## Resultados e discussão
Observamos que os agentes tendem quase todos a ir para o palco maior enquanto, uma minoria vai para as zonas de restauração ou, para as zonas verdes, ou então, desloca-se para o palco mais pequeno. Alguns agentes por vezes, ficam parados no meio do caminho, enquanto, outros cortam caminho para ir para o seu destino. Se houver vários agentes no mesmo sitio, eles tenderam a empurrar-se um pouco de forma a permanecer no mesmo sitio, ou seja, não querem sair do destino onde estão.

## Conclusões
Durante este trabalho, ficamos a saber o quanto importante era a Inteligência Artificial (IA) para a protecção das pessoas. Ao simular um ataque de explosivos, num meio controlado (simulação em Unity), foi possivel analisar e prever, dentro de certos factores, como é que as pessoas poderiam reagir a um atentado com explosivos, e como é que as podemos proteger. Para além disso, o layout do mapa também foi pensado na segurança que poderiamos trazer aos agentes no caso de ocorrer algum acidente.
Por fim, este projeto também foi nos dado bases no desenvolvimento de IA que irão ajudar para criação de videojogos futuros.

## Agradecimentos
Agradecemos pela ajuda que o nosso professor Nuno Fachada nos deu durante as aulas como também para um dos nossos colegas do curso, Steven Hall, por nos ter ajudado e dado indicações no desenvolvimento do código.

## Referências
How to use Unity NavMesh Pathfinding! (Unity Tutorial):
https://www.youtube.com/watch?v=atCOd4o7tG4&t=17s

How to Spawn Objects in Unity (Acedido: 08/04/2022): https://www.youtube.com/watch?v=aBzpvUXibw0&ab_channel=UnityAce

How to Spawn Objects by a timer (Acedido: 10/04/2022):
https://answers.unity.com/questions/1188432/i-am-trying-to-spawn-my-game-object-after-every-10.html

How to use Unity Navmesh (Acedido: 11/04/2022);
How to use Unity NavMesh Pathfinding! (Unity Tutorial) - YouTube

Stop IA Agents collide with each others (Acedido: 14/04/2022)
https://www.youtube.com/watch?v=_PA3yowVAcY&ab_channel=CodemasterJamal

How to Spawn Objects at Mouse Position in your game using the NEW UNITY INPUT SYSTEM ft. Instantiate (Acedido: 16/04/2022)
https://www.youtube.com/watch?v=JfpMIUDa-Mk&ab_channel=LithexProductions

Spawn GameObjects with a limit (Acedido: 18/04/2022)
https://thehardestwork.com/2020/12/10/how-to-build-a-spawner-in-unity/
 
How to increase Value of for example "gold" every second?
(Acedido: 20/04/2022) 
[Used to gain and lose food and stamina values over time]
https://answers.unity.com/questions/1534931/how-to-increase-value-of-for-example-gold-every-se.html
