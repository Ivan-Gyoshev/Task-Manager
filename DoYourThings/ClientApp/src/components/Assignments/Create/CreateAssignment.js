import * as React from "react";
import "./CreateAssignment.css";

export const CreateAssignment = () => {
  return (
    <section className="assign-create">
      <h2>Create assignment</h2>
      <form action="" className="assign-create-form">
        <label for="name">Name</label>
        <input type="text" />
        <label for="date">Due</label>
        <input type="datetime" />
        <label for="type">Type</label>
        <select name="" id="">
          <option value=""></option>
        </select>
        <label for="category">Category</label>
        <select name="" id="">
          <option value=""></option>
        </select>
        <a>Submit</a>
      </form>
    </section>
  );
};
