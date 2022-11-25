import { Selecao } from "./selecao.model";

export interface Jogo {
  id?: number;
  selecaoA?: Selecao;
  selecaoAId?: number;
  selecaoBId?: number;
  selecaoB?: Selecao;
  criadoEm?: string;
}
