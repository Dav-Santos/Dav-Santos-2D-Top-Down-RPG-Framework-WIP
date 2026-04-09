# Dav-Santos-2D-Top-Down-RPG-Framework-WIP
Utilizando C# e Unity
Este é um projeto de estudo focado em C# e Engenharia de Software aplicados ao desenvolvimento de jogos na Unity. O objetivo é criar um framework para um jogo de aventura/simulação com mecânicas de exploração livre, mineração, pesca e combate.

Status: Em desenvolvimento (Work In Progress). O foco atual está na implementação da arquitetura de entrada e movimentação baseada em física.

🛠 Tecnologias e Recursos Utilizados
Core & Linguagem
Unity Engine (2D)

C# Avançado: Uso de Programação Orientada a Objetos (POO), encapsulamento e diretivas de pré-processador.

Unity Input System: Implementação moderna baseada em InputActionAsset, permitindo suporte nativo a Teclado, Mouse e Gamepads.

Engenharia de Software & Arquitetura
Gerenciamento de Entrada (Input Management): Uso de InputSystem_Actions para desacoplar a lógica de comando do script de movimentação.

Física (Rigidbody2D): Movimentação baseada em física (FixedUpdate) para garantir consistência em diferentes taxas de quadros (framerate).

Automação no Editor: Scripting customizado para busca automática de assets via AssetDatabase, facilitando a configuração do componente no Inspector.

🏗 Funcionalidades Implementadas
Sistema de Movimentação: Controle fluido de personagem em 8 direções.

Mapeamento de Ações: Estrutura pronta para suportar ações de:

Attack (Combate)

Interact (Mineração, Pesca e Diálogos)

Sprint (Corrida)

Tileset e Ambiente: Configuração inicial de cenário utilizando spritesheets organizados para construções e adereços.

📝 O que estou aprimorando neste projeto?
Clean Code: Organização de scripts para serem modulares e fáceis de ler.

Boas Práticas de Física: Uso correto do Rigidbody2D e Vector2.normalized para evitar que o player ande mais rápido na diagonal.

Gestão de Versão: Uso de Git para versionamento e organização de pastas (Characters, Props, Scenes).

🚀 Próximos Passos
[ ] Implementar o sistema de inventário com Scriptable Objects.

[ ] Criar a lógica de estados (FSM) para alternar entre "Andando", "Minerando" e "Pescando".

[ ] Persistência de dados usando JSON para salvar o progresso.
