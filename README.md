# Decision Intelligence Generative AI Workshop

**[Work In Progress - Estimated Beta Launch: August 2025]**

<img style="display: block; margin: auto;" width ="700px" src="https://raw.githubusercontent.com/bartczernicki/DecisionIntelligence.GenAI.Workshop/main/Images/DecisionIntelligenceFramework/DecisionIntelligence.png">
<br/>  

Contents:  
💡 [About](#About)  
👣 [Getting Started: Choose Your Path](#getting-started-choose-your-path)  
📖 [Printed Book](#Printed-Book)  
🧱 [Workshop Modules](#Workshop-Modules)  
✅ [Requirements for Interactive Decision Notebooks](#Requirements-for-Interactive-Decision-Notebooks)  

## About 

Navigating decisions effectively is important, serving as a key differentiator for successful individuals. Therefore, decision-making ability is regarded by executives as one of the most highly desired business skills! However, effective and quality decision-making is not simple. Perhaps the intersection of Decision Theory and Generative AI can help.

This **Decision Intelligence Generative AI Workshop** is an interactive course that is paired with an upcoming book called **"Decision Intelligence with Generative AI"**. This course was designed with a focus on three key areas:  
* Illustration of important Decision-Making concepts 
* Introduction of the Decision Intelligence Framework that applies systematic decision-making  
* Application of Decision Intelligence theory with Generative AI 
* Interactive Notebooks for AI engineers/software engineers to execute the examples with an orchestration framework (Semantic Kernel & OpenAI)  

The unique workshop structure with diverse focus areas, allows this workshop to be consumed in several ways. Depending on your persona, familiarity with Decision Theory or AI acumen, you have several paths to get started.  

<img width ="750px" src="https://raw.githubusercontent.com/bartczernicki/DecisionIntelligence.GenAI.Workshop/main/Images/DecisionIntelligenceFramework.png">
<br/>  

## Getting Started: Choose Your Path  

1. 👓 **Reader Persona - Read-Only (Non-Technical)** - Ideal for non-technical users not familiar with Decision Intelligence nor Generative AI
- Nothing to install! No special requirements to read any of the workshop content. All of the text, links & images are available by just navigating to the Notebooks folder and reading the section modules sequentially. Notebooks folder:   https://github.com/bartczernicki/DecisionIntelligence.GenAI.Workshop/tree/main/Notebooks  
- All Generative AI output is pre-run and available to read in a browser  
- Recommend further detailed book resources provided in the workshop to immerse yourself in Decision Theory, Decision-Making, Cognitive Theory etc. 
- Recommend companion book **"Generative AI with Decision Intelligence"** (coming late 2025) for a more complete reading experience and advanced content not in the workshop  
2. 💻 **Technical Persona - Interactive (Technical)** - Ideal for technical users that might not be familiar with Decision Intelligence nor Generative AI, but are familiar with Jupyter Notebooks interactivity. The persona can change basic connection strings and make simple code changes.  
- All the considerations from the "Read Persona" Getting Started applies
- Set up the [Requirements for Interactive Decision Notebooks](#Requirements-for-Interactive-Decision-Notebooks) to add custom interactivity 
- Run the workshop Notebook modules sequentially (no coding required!), as the Decision Intelligence & AI concepts "build on" each other  
- C#/.NET Code will be executed but simple modifications to decision prompts, agents, configuration files are clear to added decision exploration
3. 🧑‍💻 **AI Engineer - Interactive (Advanced Technical)** - Ideal for a technical user that is familiar with programming and Generative AI
- Most of the considerations from the "Technical Persona" Getting Started applies
- Set up the [Requirements for Interactive Decision Notebooks](#Requirements-for-Interactive-Decision-Notebooks) to add custom interactivity
- Notebook modules do not "build on each other" from a programming dependency; only from a Decision Intelligence concept dependency. Therefore, you can jump in and modify where needed  
- Recommended to "Fork and Hack" and gravitate to the Decision Scenarios with most impact (change AI models, try different APIs or knowledge stores, advanced AI programming techniques, port code to your projects etc.). Advanced users are encouraged to fork this repository and try out different models or techniques.  

## Printed Book

What is the difference between the workshop the printed companion book? The Printed Book has the following features:
* Deeper focus on Decision Intelligence theory with more advanced application of Generative AI rather than a code-first focus.  
* Additional advanced real-world examples with Artificial Intelligence.  
* Chapters are organized using the Decision Intelligence Framework. A great deal less code illustrated in the book, making it easier to consume for non-technical readers.  
* References in text content to further deepen decision-making knowledge.  
* Extra Curated Chapters with "Table of Contents Lists" for Easy Lookup of: Decision Intelligence Quotes, Decision Rules, Decision Intelligence Resources.  

## Workshop Modules  

The Table of Contents below illustrates the structure of the Decision Intelligence with Generative AI Workshop. The workshop is structured on concepts broken down into Notebook modules (chapters). Each Notebook module consists of Decision Intelligence concepts and/or interactive Generative AI features that can be dynamically executed.  
> ⚠️ 
> This workshop is currently being developed in conjunction with the companion book. During this time, there will be frequent changes. Content that is available (even if partially) is noted below. Content that does not have the Availability checkmark is in early stages or not available yet. Please check back for updates!  

| Module (Chapter) | Decision Intelligence | Available | Link |
|------------------|-----------------------|-----------|------|
|1a - Decision Intelligence - Introducing the Decision Intelligence Framework| <ul><li>Framework Introduction</li><li>Eisenhower Decision Priorotization</li></ul> |✅|[Link](https://github.com/bartczernicki/DecisionIntelligence.GenAI.Workshop/blob/main/Notebooks/1a%20-%20Decision%20Intelligence%20-%20Introducing%20the%20Decision%20Intelligence%20Framework.ipynb)|
|1b - Decision Intelligence - Decision Framing| <ul><li>Decision Framing Introduction</li><li>Reframing Alternative Decision Options</li><li>Systematic Frameworks</li></ul> |✅|[Link](https://github.com/bartczernicki/DecisionIntelligence.GenAI.Workshop/blob/main/Notebooks/1b%20-%20Decision%20Intelligence%20-%20Decision%20Framing.ipynb)|
|1c - Decision Intelligence - Gathering Intelligence|<ul><li>Gathering Intelligence Introduction</li><li>Historical Examples</li><li>Intelligence with AI</li></ul>|✅|[Link](https://github.com/bartczernicki/DecisionIntelligence.GenAI.Workshop/blob/main/Notebooks/1c%20-%20Decision%20Intelligence%20-%20Gathering%20Intelligence.ipynb)|
|1d - Decision Intelligence - Decision Execution |<ul><li>Decision Execution Introduction</li><li>Three Forms of Execution</li><li>Can AI Replace a CEO?</li></ul>|✅|[Link](https://github.com/bartczernicki/DecisionIntelligence.GenAI.Workshop/blob/main/Notebooks/1d%20-%20Decision%20Intelligence%20-%20Decision%20Execution.ipynb)|


## Requirements for Interactive Decision Notebooks

1. Visual Studio Code running on your local workstation or VS Code with GitHub CodeSpaces or Azure Machine Learning Notebooks
   - **Install VS Code**: [Download Visual Studio Code](https://code.visualstudio.com/)
   - **Use GitHub CodeSpaces**: [Open in GitHub CodeSpaces](https://github.com/features/codespaces)
   - **Azure Machine Learning Notebooks**
2. Install .NET 9.x SDK:
   - **Install .NET 9 SDK**: [Download .NET 9]([https://code.visualstudio.com/](https://dotnet.microsoft.com/en-us/download/dotnet/9.0))  
3. Polyglot Notebook extension running in VS Code, which allows you to execute .NET program  
<img width ="600px" src="https://user-images.githubusercontent.com/547415/224161370-1c628967-ae0e-42b2-9c64-e3c1d7756f0b.png">
4. Clone or fork this GitHub Repository    
5. Have access to Azure OpenAI. Bing Search for internet knowledge graph (Endpoint, GPT-4 model, API Key, Bing Search API Key)  
6. When running the notebooks, select `.NET Interactive` for your VS Code Notebook kernel  
<img width ="600px" src="https://user-images.githubusercontent.com/19276747/222540791-a054da73-a111-454f-9e93-251d620a0c2d.png">

