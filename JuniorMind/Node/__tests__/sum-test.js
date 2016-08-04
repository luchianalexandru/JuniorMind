'use strict';

jest.unmock('../sum');

import React from 'react';
import ReactDOM from 'react-dom';
import TestUtils from 'react-addons-test-utils';

describe('sum', () => {
  it('adds 1 + 2 to equal 3', () => {
    const sum = require('../sum');
    expect(sum(1, 2)).toBe(3);
  });

  it('adds 1 + 2 not equal 4', () => {
  const sum = require('../sum');
  expect(sum(1, 2)).not.toBe(4);
  });
});