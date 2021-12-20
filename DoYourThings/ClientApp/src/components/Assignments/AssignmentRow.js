import * as React from "react";

const AssignmentRow = ({ assignment }) => {

  return (
    <>
      <p>{assignment.title}</p>
      <span>{assignment.date}</span>
      <a href="">
        <i className="fas fa-times"></i>
      </a>
      <a href="">
        <i className="fas fa-check"></i>
      </a>
    </>
  );
};

export default AssignmentRow;
