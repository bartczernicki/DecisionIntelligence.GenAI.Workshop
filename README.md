# Decision Intelligence Generative AI Workshop

**[Work In Progress - Estimated Beta Launch: May 2025]**

<img style="display: block; margin: auto;" width ="700px" src="https://raw.githubusercontent.com/bartczernicki/DecisionIntelligence.GenAI.Workshop/main/Images/DecisionIntelligenceFramework/DecisionIntelligence.png">
<br/>  

Contents:  
[About](#About)  
[Different Ways To Get Started](#Different-Ways-To-Get-Started)  
[Requirements for Interactive Decision Notebooks](#Requirements-for-Interactive-Decision-Notebooks)  

## About 

The **Decision Intelligence GenAI Workshop** is an interactive course that pairs with an upcoming book called **"Decision Intelligence with Generative AI"**. This course primarily focuses on three areas:  
* Introduction to Decision-Making with a Decision Intelligence Framework that covers systematic processes of making decisions   
* Application of Decision Intelligence theory with Generative AI 
* Interative Notebooks for AI engineers/software engineers to execute the examples with an orchestration framework (Semantic Kernel & OpenAI)  

The unique structure with diverse focus areas, allows the workshop to be consumed in several ways. Depending on your familiarity with decision theory or AI acumen, you have several paths to get started.  

<img width ="750px" src="https://raw.githubusercontent.com/bartczernicki/DecisionIntelligence.GenAI.Workshop/main/Images/DecisionIntelligenceFramework.png">
<br/>  

## Different Ways To Get Started

1. **Read Persona** - Ideal for non-technical users not familiar with Decision Intelligence nor Generative AI
- Nothing to install! No special requirements to read any of the workshop content. All the of the text, links & images are available by just navigating to the Notebooks folder and reading the section modules sequentially. Notebooks folder:   https://github.com/bartczernicki/DecisionIntelligence.GenAI.Workshop/tree/main/Notebooks  
- All Generative AI output is pre-run and available to read in a browser  
- Recommend further detailed book resources provided in the workshop to immerse yourself in Decision Theory, Decision-Making, Cognitive Theory etc. 
- Recommend companion book **"Generative AI with Decision Intelligence"** (coming late 2025) for more complete and advanced content  
2. **Technical Persona** - Ideal for technical users that might not be familiar with Decision Intelligence nor Generative AI, but are familiar with Jupyter Notebooks interactivity
- All the considerations from the "Read Persona" Getting Started applies
- Set up the [Requirements for Interactive Decision Notebooks](#Requirements-for-Interactive-Decision-Notebooks) to add custom interactivity 
- Run the workshop Notebook modules sequentially, as the Decision Intelligence & AI concepts "build on" each other
- C#/.NET Code will be executed but simple modifications to decision prompts, agents, configuration files are clear to added decision exploration
3. **Decision Intelligence AI Engineer** - Ideal for a technical user that is familiar with programming and Generative AI
- Most of the considerations from the "Technical Persona" Getting Started applies
- Set up the [Requirements for Interactive Decision Notebooks](#Requirements-for-Interactive-Decision-Notebooks) to add custom interactivity
- Notebook modules do not "build on each other" from a programming dependency; only from a concept dependency. Therefore, you can jump in and modify as needed 
- Recommended to "Fork and Hack" and gravitate to the Decision Scenarios with most impact (change AI models, try different APIs or knowledge stores, advanced AI programming techniques etc.)

## Requirements for Interactive Decision Notebooks

1. Visual Studio Code running on your local workstation or VS Code with GitHub CodeSpaces or Azure Machine Learning Notebooks  
2. Install .NET 9.x SDK: https://dotnet.microsoft.com/en-us/download/dotnet/9.0 
3. Polyglot Notebook extension running in VS Code, which allows you to execute .NET program  
<img width ="600px" src="https://user-images.githubusercontent.com/547415/224161370-1c628967-ae0e-42b2-9c64-e3c1d7756f0b.png">

5. Clone or fork this GitHub Repository    
6. Have access to Azure OpenAI. Bing Search for internet knowledge graph (Endpoint, GPT-4 model, API Key, Bing Search API Key)  
7. When running the notebooks, select `.NET Interactive` for your VS Code Notebook kernel  
<img width ="600px" src="https://user-images.githubusercontent.com/19276747/222540791-a054da73-a111-454f-9e93-251d620a0c2d.png">

