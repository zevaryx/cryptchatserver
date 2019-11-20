# -*- coding: utf-8 -*-
# Generated by the protocol buffer compiler.  DO NOT EDIT!
# source: auth.proto

import sys
_b=sys.version_info[0]<3 and (lambda x:x) or (lambda x:x.encode('latin1'))
from google.protobuf import descriptor as _descriptor
from google.protobuf import message as _message
from google.protobuf import reflection as _reflection
from google.protobuf import symbol_database as _symbol_database
# @@protoc_insertion_point(imports)

_sym_db = _symbol_database.Default()




DESCRIPTOR = _descriptor.FileDescriptor(
  name='auth.proto',
  package='cryptchatprotos.responses.auth',
  syntax='proto3',
  serialized_options=_b('\252\002\036CryptChatProtos.Responses.Auth'),
  serialized_pb=_b('\n\nauth.proto\x12\x1e\x63ryptchatprotos.responses.auth\"\x1c\n\x0cSaltResponse\x12\x0c\n\x04salt\x18\x01 \x01(\t\"M\n\rLoginResponse\x12\x0b\n\x03_id\x18\x01 \x01(\t\x12\x10\n\x08username\x18\x02 \x01(\t\x12\x0e\n\x06pubkey\x18\x03 \x01(\t\x12\r\n\x05token\x18\x04 \x01(\t\"0\n\x0cUserResponse\x12\x10\n\x08username\x18\x01 \x01(\t\x12\x0e\n\x06pubkey\x18\x02 \x01(\t\".\n\x10RegisterResponse\x12\x0b\n\x03_id\x18\x01 \x01(\t\x12\r\n\x05token\x18\x02 \x01(\tB!\xaa\x02\x1e\x43ryptChatProtos.Responses.Authb\x06proto3')
)




_SALTRESPONSE = _descriptor.Descriptor(
  name='SaltResponse',
  full_name='cryptchatprotos.responses.auth.SaltResponse',
  filename=None,
  file=DESCRIPTOR,
  containing_type=None,
  fields=[
    _descriptor.FieldDescriptor(
      name='salt', full_name='cryptchatprotos.responses.auth.SaltResponse.salt', index=0,
      number=1, type=9, cpp_type=9, label=1,
      has_default_value=False, default_value=_b("").decode('utf-8'),
      message_type=None, enum_type=None, containing_type=None,
      is_extension=False, extension_scope=None,
      serialized_options=None, file=DESCRIPTOR),
  ],
  extensions=[
  ],
  nested_types=[],
  enum_types=[
  ],
  serialized_options=None,
  is_extendable=False,
  syntax='proto3',
  extension_ranges=[],
  oneofs=[
  ],
  serialized_start=46,
  serialized_end=74,
)


_LOGINRESPONSE = _descriptor.Descriptor(
  name='LoginResponse',
  full_name='cryptchatprotos.responses.auth.LoginResponse',
  filename=None,
  file=DESCRIPTOR,
  containing_type=None,
  fields=[
    _descriptor.FieldDescriptor(
      name='_id', full_name='cryptchatprotos.responses.auth.LoginResponse._id', index=0,
      number=1, type=9, cpp_type=9, label=1,
      has_default_value=False, default_value=_b("").decode('utf-8'),
      message_type=None, enum_type=None, containing_type=None,
      is_extension=False, extension_scope=None,
      serialized_options=None, file=DESCRIPTOR),
    _descriptor.FieldDescriptor(
      name='username', full_name='cryptchatprotos.responses.auth.LoginResponse.username', index=1,
      number=2, type=9, cpp_type=9, label=1,
      has_default_value=False, default_value=_b("").decode('utf-8'),
      message_type=None, enum_type=None, containing_type=None,
      is_extension=False, extension_scope=None,
      serialized_options=None, file=DESCRIPTOR),
    _descriptor.FieldDescriptor(
      name='pubkey', full_name='cryptchatprotos.responses.auth.LoginResponse.pubkey', index=2,
      number=3, type=9, cpp_type=9, label=1,
      has_default_value=False, default_value=_b("").decode('utf-8'),
      message_type=None, enum_type=None, containing_type=None,
      is_extension=False, extension_scope=None,
      serialized_options=None, file=DESCRIPTOR),
    _descriptor.FieldDescriptor(
      name='token', full_name='cryptchatprotos.responses.auth.LoginResponse.token', index=3,
      number=4, type=9, cpp_type=9, label=1,
      has_default_value=False, default_value=_b("").decode('utf-8'),
      message_type=None, enum_type=None, containing_type=None,
      is_extension=False, extension_scope=None,
      serialized_options=None, file=DESCRIPTOR),
  ],
  extensions=[
  ],
  nested_types=[],
  enum_types=[
  ],
  serialized_options=None,
  is_extendable=False,
  syntax='proto3',
  extension_ranges=[],
  oneofs=[
  ],
  serialized_start=76,
  serialized_end=153,
)


_USERRESPONSE = _descriptor.Descriptor(
  name='UserResponse',
  full_name='cryptchatprotos.responses.auth.UserResponse',
  filename=None,
  file=DESCRIPTOR,
  containing_type=None,
  fields=[
    _descriptor.FieldDescriptor(
      name='username', full_name='cryptchatprotos.responses.auth.UserResponse.username', index=0,
      number=1, type=9, cpp_type=9, label=1,
      has_default_value=False, default_value=_b("").decode('utf-8'),
      message_type=None, enum_type=None, containing_type=None,
      is_extension=False, extension_scope=None,
      serialized_options=None, file=DESCRIPTOR),
    _descriptor.FieldDescriptor(
      name='pubkey', full_name='cryptchatprotos.responses.auth.UserResponse.pubkey', index=1,
      number=2, type=9, cpp_type=9, label=1,
      has_default_value=False, default_value=_b("").decode('utf-8'),
      message_type=None, enum_type=None, containing_type=None,
      is_extension=False, extension_scope=None,
      serialized_options=None, file=DESCRIPTOR),
  ],
  extensions=[
  ],
  nested_types=[],
  enum_types=[
  ],
  serialized_options=None,
  is_extendable=False,
  syntax='proto3',
  extension_ranges=[],
  oneofs=[
  ],
  serialized_start=155,
  serialized_end=203,
)


_REGISTERRESPONSE = _descriptor.Descriptor(
  name='RegisterResponse',
  full_name='cryptchatprotos.responses.auth.RegisterResponse',
  filename=None,
  file=DESCRIPTOR,
  containing_type=None,
  fields=[
    _descriptor.FieldDescriptor(
      name='_id', full_name='cryptchatprotos.responses.auth.RegisterResponse._id', index=0,
      number=1, type=9, cpp_type=9, label=1,
      has_default_value=False, default_value=_b("").decode('utf-8'),
      message_type=None, enum_type=None, containing_type=None,
      is_extension=False, extension_scope=None,
      serialized_options=None, file=DESCRIPTOR),
    _descriptor.FieldDescriptor(
      name='token', full_name='cryptchatprotos.responses.auth.RegisterResponse.token', index=1,
      number=2, type=9, cpp_type=9, label=1,
      has_default_value=False, default_value=_b("").decode('utf-8'),
      message_type=None, enum_type=None, containing_type=None,
      is_extension=False, extension_scope=None,
      serialized_options=None, file=DESCRIPTOR),
  ],
  extensions=[
  ],
  nested_types=[],
  enum_types=[
  ],
  serialized_options=None,
  is_extendable=False,
  syntax='proto3',
  extension_ranges=[],
  oneofs=[
  ],
  serialized_start=205,
  serialized_end=251,
)

DESCRIPTOR.message_types_by_name['SaltResponse'] = _SALTRESPONSE
DESCRIPTOR.message_types_by_name['LoginResponse'] = _LOGINRESPONSE
DESCRIPTOR.message_types_by_name['UserResponse'] = _USERRESPONSE
DESCRIPTOR.message_types_by_name['RegisterResponse'] = _REGISTERRESPONSE
_sym_db.RegisterFileDescriptor(DESCRIPTOR)

SaltResponse = _reflection.GeneratedProtocolMessageType('SaltResponse', (_message.Message,), {
  'DESCRIPTOR' : _SALTRESPONSE,
  '__module__' : 'auth_pb2'
  # @@protoc_insertion_point(class_scope:cryptchatprotos.responses.auth.SaltResponse)
  })
_sym_db.RegisterMessage(SaltResponse)

LoginResponse = _reflection.GeneratedProtocolMessageType('LoginResponse', (_message.Message,), {
  'DESCRIPTOR' : _LOGINRESPONSE,
  '__module__' : 'auth_pb2'
  # @@protoc_insertion_point(class_scope:cryptchatprotos.responses.auth.LoginResponse)
  })
_sym_db.RegisterMessage(LoginResponse)

UserResponse = _reflection.GeneratedProtocolMessageType('UserResponse', (_message.Message,), {
  'DESCRIPTOR' : _USERRESPONSE,
  '__module__' : 'auth_pb2'
  # @@protoc_insertion_point(class_scope:cryptchatprotos.responses.auth.UserResponse)
  })
_sym_db.RegisterMessage(UserResponse)

RegisterResponse = _reflection.GeneratedProtocolMessageType('RegisterResponse', (_message.Message,), {
  'DESCRIPTOR' : _REGISTERRESPONSE,
  '__module__' : 'auth_pb2'
  # @@protoc_insertion_point(class_scope:cryptchatprotos.responses.auth.RegisterResponse)
  })
_sym_db.RegisterMessage(RegisterResponse)


DESCRIPTOR._options = None
# @@protoc_insertion_point(module_scope)