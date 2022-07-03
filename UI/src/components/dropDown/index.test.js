import { render, screen, fireEvent } from "@testing-library/react";
import DropDown from "./index";

const data = [
  {
    id: 1,
    name: "CR1",
  },
];

const setup = () => {
  const utils = render(<DropDown options={data} onChange={() => {}} />);
  const input = utils.getByLabelText("ticker-input");
  return {
    input,
    ...utils,
  };
};

test("renders drop down", () => {
  render(<DropDown />);
  const linkElement = screen.getByText(/Select option/i);
  expect(linkElement).toBeInTheDocument();
});

test("renders drop down label", () => {
  render(<DropDown label="Test Label" />);
  const linkElement = screen.getByText(/Test Label/i);
  expect(linkElement).toBeInTheDocument();
});

test("renders drop down options", () => {
  render(<DropDown options={data} value={1} />);
  const linkElement = screen.getByText(/CR1/i);
  expect(linkElement).toBeInTheDocument();
});

test("renders drop down value", () => {
  const { input } = setup();
  fireEvent.change(input, { target: { value: "" } });
  expect(input.value).toBe("");
});
