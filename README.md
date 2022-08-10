# Ultimate Most Advanced - Console Version

<div>
  <p>
    <a href="https://github.com/MrSev7en/ultimate-most-advanced">
      <img src="https://badgen.net/badge/build/passing/green">
      <img src="https://badgen.net/badge/deprecated/project/black">
    </a>
  </p>
</div>

🔰 An advanced console for windows users including several useful functions.
This project is deprecated. New version soon.

## Functions
💻 Ultimate Most Advanced (aka U.M.A) was developed with purpose to make several http requests in high scale.
At this version, project inlcudes these functions:

- HTTP request
- Socket request
- Multicore threading management

## Issues
🏗️ Collaborate with me sending [issues](https://github.com/MrSev7en/ultimate-most-advanced/issues)

## Examples

### Without multicore
Using less cpu and ram;

- Sending an socket request:
```csharp
web send -a <ip> -a <request amount> -p <size> -i <port>
```

- Sending an http request:
```csharp
web send -s <url> -a <request amount> -p <size> -w <data (use _ instead spaces)>
```

### With multicore
Using all available cpu and ram;

- Enable muticore:
```csharp
experimental true
```
```csharp
web multicore -v <threads amount>
```

### Useful commands

- To clear all console input:
```csharp
clear
```

## Socials
🐦 Twitter: [@MrSev7en](https://twitter.com/MrSev7en/)
<br>
📷 Instagram: [@MrSev7en](https://instagram.com/MrSev7en/)

## License
This project was based on [MIT](https://github.com/MrSev7en/ultimate-most-advanced/blob/master/LICENSE) license.
