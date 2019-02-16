import 'package:flutter/material.dart';
import "fractal_painter.dart";

void main() => runApp(MyApp());

class MyApp extends StatelessWidget {
  @override
  Widget build(BuildContext context) {
    return MaterialApp(
      title: 'Flutter Demo',
      home: MyHomePage(),
    );
  }
}

class MyHomePage extends StatefulWidget {
  @override
  _MyHomePageState createState() => _MyHomePageState();
}

class _MyHomePageState extends State<MyHomePage> {
  int _counter = 0;

  void _incrementCounter() {
    setState(() {
      _counter++;
    });
  }

  void _decrementCounter() {
    setState(() {
      _counter--;
    });
  }
  @override
  Widget build(BuildContext context) {
    return Scaffold(
      appBar: AppBar(
        title: Text("Fractals"),
      ),
      body: Center(
        child: Column(
          mainAxisAlignment: MainAxisAlignment.end,
          children: <Widget>[
            Container(padding: EdgeInsets.only(bottom: 5.0),child: Fractal(_counter.toDouble())),
            Text(
              'You have pushed the button this many times:',
            ),
            Text(
              '$_counter',
              style: Theme.of(context).textTheme.display1,
            ),

            Row(mainAxisAlignment: MainAxisAlignment.spaceEvenly,
              children: <Widget>[
              RaisedButton(onPressed: _decrementCounter, child: Text("-"),),
              RaisedButton(onPressed: _incrementCounter, child: Text("+"),),
            ],
            ),
          ],
        ),
      ),
    );
  }
}
