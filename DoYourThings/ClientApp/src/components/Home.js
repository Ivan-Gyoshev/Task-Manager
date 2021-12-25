import React, { Component } from "react";
import { Link } from "react-router-dom";
import "./Home.css";

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
              <Link to="/dashboard/today">Today</Link>
            </li>
            <li>
              <Link to="/dashboard/7days">In 7 days</Link>
            </li>
          </ul>
        </nav>
        <div className="logged-intro">
          <article className="intro-heading">
            <h1>Wellcome fellow user!</h1>
          </article>
          <p>Struggling with your organization?</p>
          <p>
            Let us help you be more productive by organizing your assignments!
          </p>
          <p>
            Click on the menu on your right and increase your productivity
          </p>
        </div>
      </section>
    );
  }
}
