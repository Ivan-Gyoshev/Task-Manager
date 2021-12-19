import { React } from "react";

const AssignmentRow = ({ assignemnt }) => {
  return (
    <>
      <p>{assignemnt.title}</p>
      <span>{assignemnt.date}</span>
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
