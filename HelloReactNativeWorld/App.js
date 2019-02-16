import React, { Component } from 'react';
import { Alert, AppRegistry, Button, StyleSheet, View } from 'react-native';
// import Canvas from 'react-native-canvas';

export default class HelloWorldApp extends Component {
  render() {
    return (
      <View style={styles.container}>
        <View style={styles.buttonContainer}>
          <Button
            onPress={this._draw}
            title="Press Me"
          />
        </View>
      </View>
    );
  }
}

let count = 0;

function _draw(){
	count++;
	Alert.alert(count);
}





