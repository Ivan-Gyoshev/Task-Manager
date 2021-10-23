import React, { Component } from 'react';

export class Home extends Component {
  static displayName = Home.name;

  render () {
    return (
      <div>
            <h1>Hello from the Task Manager!</h1>
            <img src="./public/logo.png"></img>
      </div>
    );
  }
}
