# Cybersecurity Awareness Bot

## 1. Project Overview

The Cybersecurity Awareness Bot is a C# desktop application developed to help users learn about cybersecurity and understand how to protect themselves from common online threats.

The application provides an interactive graphical user interface (GUI) where users can ask questions, explore cybersecurity topics and receive helpful advice. It is designed to make cybersecurity awareness easier to understand through conversations and practical examples.

## 2. Project Objectives

The main objectives of this project are to:

- Educate users about common cybersecurity threats.
- Provide relevant advice on passwords, scams, phishing, privacy and malware.
- Create an interactive chatbot using a Windows desktop interface.
- Use collections and structured programming techniques to manage responses.
- Implement conversation memory and follow-up interactions.
- Detect user sentiment and respond appropriately.
- Include an audio greeting to improve the user experience.
- Provide interactive cybersecurity quiz and task-list features.

## 3. Features

### 3.1 Graphical User Interface

The application uses Windows Presentation Foundation (WPF) to provide a desktop interface. Users can interact with the chatbot through a message input field, send button, topic buttons and conversation area.

### 3.2 Cybersecurity Advice

The chatbot recognises cybersecurity-related keywords and provides relevant information about topics such as:

- Password security
- Scams and phishing
- Online privacy
- Malware
- Wi-Fi security
- Authentication

### 3.3 Random Responses

The chatbot can select from multiple predefined responses for supported topics. This helps make conversations less repetitive.

### 3.4 Conversation Flow

The application supports follow-up messages, such as asking for another tip or requesting more information about the current topic.

### 3.5 Memory and Recall

The chatbot can store selected information from the conversation, such as the user's name and current topic, and use that information in later responses.

### 3.6 Sentiment Detection

The chatbot identifies selected expressions that may indicate worry, curiosity or frustration. It uses this information to provide an appropriate response and relevant guidance.

### 3.7 Audio Greeting

The application uses a WAV audio file named `greeting.wav` to play a greeting when the main window starts. The audio functionality is implemented in the `AudioPlayer` class.

### 3.8 Cybersecurity Quiz

The application includes a quiz window that allows users to answer questions and receive feedback on their answers.

### 3.9 Task List

The task-list window allows users to manage cybersecurity-related tasks, mark tasks as completed and remove completed items.

### 3.10 Error Handling

The chatbot provides fallback responses for unsupported or unexpected messages to help prevent interruptions during normal interaction.

## 4. Technologies Used

- **C#:** Application logic and chatbot functionality.
- **.NET / WPF:** Desktop application framework and graphical user interface.
- **XAML:** Layout and visual design of the application windows.
- **Collections:** Dictionaries, arrays and lists for organising data and responses.
- **Random class:** Selection of predefined chatbot responses.
- **System.Media.SoundPlayer:** Playback of the WAV greeting.
- **Visual Studio:** Application development, building and debugging.
- **Git and GitHub:** Source-code version control and project submission.

## 5. Project Structure

The project contains the following main files and folders. The exact structure may vary depending on the final version of the project.

```text
CybersecurityAwarenessBot/
│
├── Audio/
│   └── greeting.wav
│
├── Classes/
│   ├── AudioPlayer.cs
│
│  
│   
│
├── MainWindow.xaml
├── MainWindow.xaml.cs
├── QuizWindow.xaml