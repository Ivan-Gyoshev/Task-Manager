import * as React from "react";
import { useState, useRef } from 'react';
import "./CreateAssignment.css";
import {Button, Form, Label, Input } from 'reactstrap';
import { Link } from "react-router-dom";

const required = (value) => {
  if (!value) {
    return (
      <div className="alert alert-danger" role="alert">
        This field is required!
      </div>
    );
  }
};

const validateTitle = (value) => {
  if (value.length < 2 || value.length > 100) {
    return (
      <div className="alert alert-danger" role="alert">
        The password must be between 6 and 40 characters.
      </div>
    );
  }
};

const validateDate = (value) => {
  if (value < 1 || value >= new Date().getFullYear()) {
    return (
      <div className="alert alert-danger" role="alert">
        Year must be between 1 and {new Date().getFullYear()}.
      </div>
    );
  }
};

export const CreateAssignment = () => {
  const form = useRef();

  const [title, setTitle] = useState('');
  const [date, setDate] = useState('');
  const [category, setCategory] = useState('');
  const [successful, setSuccessful] = useState(false);

  return (
    <section className="assign-create">
      <h2>Create assignment</h2>
      <Form action="" className="assign-create-form">
        <Label for="name">Name</Label>
        <Input type="text" />
        <Label for="date">Due</Label>
        <Input type="datetime" />
        <Label for="type">Type</Label>
        <select name="" id="">
          <option value=""></option>
        </select>
        <Label for="category">Category</Label>
        <select name="" id="">
          <option value=""></option>
        </select>
        <Link>Submit</Link>
      </Form>
    </section>
  );
};
