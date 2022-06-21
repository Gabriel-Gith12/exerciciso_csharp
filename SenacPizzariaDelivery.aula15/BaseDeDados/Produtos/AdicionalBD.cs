﻿using Entidades.Enumeradores;
using Entidades.Pessoas;
using Entidades.Produtos;
using Entidades.Sistema;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;

namespace BaseDeDados.Produtos
{
    public class AdicionalBD
    {
        // método lista recebe por parametro a situacao do usuario(ativo, inativo, todos)
        public List<EntidadeViewPesquisa> ListarEntidadesViewPesquisa(Status status)
        {
            var listaEntidades = new List<EntidadeViewPesquisa>();

            using( MySqlConnection conexao = 
                   ConexaoBaseDados.getInstancia().getConexao()
                 )
            {
                try
                {
                    conexao.Open();
                    MySqlCommand comando = new MySqlCommand();
                    comando = conexao.CreateCommand();

                    // consulta SQL
                    string query = @"SELECT codigo, descricao, situacao 
                                            FROM adicional ";
                    // se status que eu quero pesquisar for diferente de todos
                    if(status != Status.Todos)
                    {
                        // adiciono a clausula WHERE
                        query += " WHERE situacao = @situacao";
                        comando.Parameters.AddWithValue("situacao", (int)status);
                    }

                    
                    comando.CommandText = query;
                    MySqlDataReader reader = comando.ExecuteReader();

                    while (reader.Read())
                    {
                        var oEntidade = new EntidadeViewPesquisa();

                        // ler propriedades do data reader
                        oEntidade.Codigo = Convert.ToInt32(reader["codigo"].ToString());
                        oEntidade.Descricao = reader["descricao"].ToString();
                        oEntidade.Status = (Status)Convert.ToInt16(reader["situacao"].ToString());
                        listaEntidades.Add(oEntidade);
                    }
                }
                catch (MySqlException ex)
                {
                    throw new Exception(ex.ToString());
                }
                finally {
                    conexao.Close();
                }
                
            }

            return listaEntidades;
        }

        public List<Adicional> ListarAdicionais()
        {
            var listaAdicional = new List<Adicional>();

            using (MySqlConnection conexao =
                   ConexaoBaseDados.getInstancia().getConexao()
                 )
            {
                try
                {
                    conexao.Open();
                    MySqlCommand comando = new MySqlCommand();
                    comando = conexao.CreateCommand();
                    comando.CommandText = "SELECT * FROM adicional " +
                                          "WHERE situacao = 1; ";
                    MySqlDataReader reader = comando.ExecuteReader();

                    while (reader.Read())
                    {
                        var oAdicional = new Adicional();

                        // ler propriedades do data reader

                        oAdicional.Codigo = Convert.ToInt32(reader["codigo"].ToString());
                        oAdicional.Descricao = reader["descricao"].ToString();
                        oAdicional.Observacao = reader["observacao"].ToString();
                        oAdicional.Valor = Convert.ToDecimal(reader["valor"].ToString());
                        oAdicional.DtAlteracao = Convert.ToDateTime(reader["dt_alteracao"].ToString());
                        oAdicional.CodigoUsrAlteracao = Convert.ToInt32(reader["codigo_usr_alteracao"].ToString());
                        oAdicional.Status = (Status)Convert.ToInt16(reader["situacao"].ToString());
                        listaAdicional.Add(oAdicional);
                    }
                }
                catch (MySqlException ex)
                {
                    throw new Exception(ex.ToString());
                }
                finally
                {
                    conexao.Close();
                }

            }

            return listaAdicional;
        }

        public Adicional Buscar(int codigo)
        {
            var oAdicional = new Adicional();

            using (MySqlConnection conexao =
                   ConexaoBaseDados.getInstancia().getConexao()
                 )
            {
                try
                {
                    conexao.Open();
                    MySqlCommand comando = new MySqlCommand();
                    comando = conexao.CreateCommand();
                    comando.CommandText = " SELECT * FROM adicional " +
                                          " WHERE codigo = @codigo ";
                    comando.Parameters.AddWithValue("codigo", (int)codigo);
                    MySqlDataReader reader = comando.ExecuteReader();

                    while (reader.Read())
                    {
                        oAdicional.Codigo = Convert.ToInt32(reader["codigo"].ToString());
                        oAdicional.Descricao = reader["descricao"].ToString();
                        oAdicional.Observacao = reader["observacao"].ToString();
                        oAdicional.Valor = Convert.ToDecimal(reader["valor"].ToString());
                        oAdicional.DtAlteracao = Convert.ToDateTime(reader["dt_alteracao"].ToString());
                        oAdicional.CodigoUsrAlteracao = Convert.ToInt32(reader["codigo_usr_alteracao"].ToString());
                        oAdicional.Status = (Status)Convert.ToInt16(reader["situacao"].ToString());
                    }
                }
                catch (MySqlException ex)
                {
                    throw new Exception(ex.ToString());
                }
                finally
                {
                    conexao.Close();
                }
            }
            return oAdicional;
        }
    }
}
