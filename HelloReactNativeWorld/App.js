import React, { Component } from 'react';
import { Alert, AppRegistry, Button, StyleSheet, View } from 'react-native';
// import Canvas from 'react-native-canvas';

export default class HelloWorldApp extends Component {
  let count = 0;
  const styles = StyleSheet.create({
  container: {
   flex: 1,
   justifyContent: 'center',
  },
  buttonContainer: {
    margin: 20
  },
  alternativeLayoutButtonContainer: {
    margin: 20,
    flexDirection: 'row',
    justifyContent: 'space-between'
  }
});
  _draw(){
    count++;
    Alert.alert(count);
  }

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








