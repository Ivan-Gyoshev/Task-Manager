import * as React from "react";
import AssignmentRow from "./AssignmentRow";
const AssignmentCard = ({ assignments }) => {
  return (
    <>
      {assignments.length > 0 ? (
        <>
          {assignments.map((x) => (
            <AssignmentRow assignment={x} />
          ))}
        </>
      ) : (
        <h2>You don't have any assignments yet.</h2>
      )}
    </>
  );
};

export default AssignmentCard;
