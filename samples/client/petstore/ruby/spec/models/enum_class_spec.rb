=begin
#Swagger Petstore

#This spec is mainly for testing Petstore server and contains fake endpoints, models. Please do not use this for any other purpose. Special characters: \" \\

OpenAPI spec version: 1.0.0
Contact: apiteam@swagger.io
Generated by: https://github.com/swagger-api/swagger-codegen.git
Swagger Codegen version: 2.3.0-SNAPSHOT

=end

require 'spec_helper'
require 'json'
require 'date'

# Unit tests for Petstore::EnumClass
# Automatically generated by swagger-codegen (github.com/swagger-api/swagger-codegen)
# Please update as you see appropriate
describe 'EnumClass' do
  before do
    # run before each test
    @instance = Petstore::EnumClass.new
  end

  after do
    # run after each test
  end

  describe 'test an instance of EnumClass' do
    it 'should create an instact of EnumClass' do
      expect(@instance).to be_instance_of(Petstore::EnumClass)
    end
  end
end

