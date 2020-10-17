# Ultimate Most Advanced - Console Version
🔰 A advanced console for windows users, with a lot functions. Of course is not finished, but I guess I wanna keep working at that.
Coming Soon updates will come.

## Description
💻 Ultimate Most Advanced or U.M.A, started when I tried to use Windows Command Prompt, to make HTTP's Request... How you thinking.. Not worked.
So, I created this and have a lot functions, like:

- Web HTTP request.
- IP Address request.
- Socket IP Send, with prefab words selected by user.
- Multicore threads sending.
- And more functions.

🚧 Warning, when you wanna send a prefab word to IP Address or Web HTTP Request, split the words with **_** or **-**, or not will work. Other thing, the Web HTTP Request, works with HTTPS too.

## Help Me
🏗️ If you finded a bug or something like, put in [Issues](https://github.com/MrSev7en/ultimate-most-advanced/issues), detail then, and tell me everything thats happen.

## Command Examples

### Without Multicore
Using less CPU and RAM.

- First example, sending a IP Request for IP Address.
```csharp
web send -a <ip> -a <request amount> -p <request size> -i <port>
```

- Second example, sending a Web HTTP Request for a Website.
```csharp
web send -s <url> -a <request amount> -p <request size> -w <request word (see above rules)>
```

### With Multicore
Using total CPU and RAM.

- To enable multicore.
```csharp
experimental true
```
```csharp
web multicore -v <threads size>
```

<br>

- First example, sending a IP Request for IP Address.
```csharp
web send -a <ip> -a <request amount> -p <request size> -i <port>
```

- Second example, sending a Web HTTP Request for a Website.
```csharp
web send -s <url> -a <request amount> -p <request size> -w <request word (see above rules)>
```

### Other Commands

- Clear all console input and output.
```csharp
clear
```

## Social Medias
🐦 Twitter: [@MrSev7en](https://twitter.com/MrSev7en/)

## License
This project particularly don't have restrictions. Community help will be great, if you wanna help us with your modification, send in [Pull requests](https://github.com/MrSev7en/ultimate-most-advanced/pulls).

But the license is [MIT](https://github.com/MrSev7en/ultimate-most-advanced/blob/master/LICENSE), check clicking in link.

If you wanna share this, please give me copyright.
