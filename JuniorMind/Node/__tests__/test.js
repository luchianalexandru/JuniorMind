jest.unmock("../inputComponent");

import Input from "../inputComponent";
import React from "react";
import {shallow} from "enzyme";

describe("Input component", () => {
    it("has the number of elements", () => {
        const wrapper = shallow(<Input length="3" />);
        expect(wrapper.find("div")).toHaveText("3");
    });
});
