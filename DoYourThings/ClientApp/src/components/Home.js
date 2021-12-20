import React, { Component } from "react";

import './Home.css'

export class Home extends Component {
  static displayName = Home.name;

  render() {
    return (
      <section className="home">
        <nav className="home-nav">
          <article className="home-nav-heading"></article>
          <h1>Select</h1>
          <i className="far fa-arrow-alt-circle-down"></i>
          <ul className="home-nav-list">
            <li>
              <a href="/dashboard">Daily</a>
            </li>
            <li>
              <a href="">Weekly</a>
            </li>
            <li>
              <a href="">Monthly</a>
            </li>
          </ul>
        </nav>
       
      </section>
    );
  }
}
