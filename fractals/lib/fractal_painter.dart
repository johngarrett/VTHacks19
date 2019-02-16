import 'package:flutter/material.dart';
import 'dart:math';

class Fractal extends StatefulWidget {
  Fractal(this.depth);

  final double depth;

  @override
  State<StatefulWidget> createState() => FractalState(depth);
}

class FractalState extends State<Fractal> with TickerProviderStateMixin {
  double _desiredDepth;
  double _currentDepth;
  Animation<double> animation;
  AnimationController controller;

  FractalState(_desiredDepth) {
    this._desiredDepth = _desiredDepth;
    this._currentDepth = _desiredDepth - 1.0;
  }

  @override
  void didUpdateWidget(Fractal oldWidget) {
    super.didUpdateWidget(oldWidget);
    this._desiredDepth = this.widget.depth;

    if (animation != null && !animation.isCompleted) {
      controller.stop();
      controller.dispose();
    }

    controller = AnimationController(
        duration: Duration(milliseconds: 500), vsync: this);

    animation = Tween(begin: _currentDepth, end: _desiredDepth).animate(controller)
      ..addListener(() {
        setState(() {
          _currentDepth = animation.value;
        });
      });

    controller.forward();
  }

  @override
  Widget build(BuildContext context) {
    return CustomPaint(painter: FractalPainter(this._currentDepth));
  }
}

class FractalPainter extends CustomPainter {
  double _depth;
  final double edgeLength = 8.0;

  FractalPainter(this._depth);

  void paint(Canvas canvas, Size size) {
    drawPart(
        canvas,
        size.bottomCenter(Offset(0.0, 0.0)),
        -pi/2,
        _depth
    );
  }

  double lines = 9;
  double lineCount = 0;
  void drawPart(Canvas canvas, Offset start, double angle, double depth) {
    if (depth <= 0.0) {
      return;
    }
//    depth = 8.0;
//    if (lineCount >= lines) {
//      return;
//    }

    lineCount++;
    print(lineCount);
//    sets the end point for the line
    var end = start.translate(
        cos(angle) * depth * edgeLength,
        sin(angle) * depth * edgeLength
    );

    var paint = Paint()
      ..color = Colors.green
      ..strokeWidth = depth
      ..strokeCap = StrokeCap.round;

    //draw line from start to end
    canvas.drawLine(start, end, paint);

      //draw two lines from end of new line
      var angleStep = pi / 6;
      if (angle <= 0 && angle >= -pi) {
//        if (lines % 2 ==0) {
          drawPart(canvas, end, angle - angleStep, depth - 1.0);
//        } else {
          drawPart(canvas, end, angle + angleStep, depth - 1.0);
//        }
      }
//      }
  }

  @override
  bool shouldRepaint(FractalPainter oldDelegate) {
    return oldDelegate._depth != _depth;
  }
}